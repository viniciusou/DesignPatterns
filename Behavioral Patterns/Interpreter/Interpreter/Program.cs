using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    /// <summary>
    /// The interpreter pattern specifies how to evaluate sentences in a language. The basic 
    /// idea is to have a class for each symbol (terminal or nonterminal) in a specialized 
    /// computer language. The syntax tree of a sentence in the language is an instance of 
    /// the composite pattern and is used to evaluate (interpret) the sentence for a client.
    /// 
    /// The interpreter is a component that processes structured text data. Does so by 
    /// turning it into separate lexical tokens (lexing) and the interpreting sequences of 
    /// said tokens (parsing).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // ( 13 + 4 ) - ( 12 + 1)
            string input = "(13+4)-(12+1)";
            var tokens = Lex(input);
            Console.WriteLine(string.Join("\t", tokens));

            var parsed = Parse(tokens);
            Console.WriteLine($"{input} = {parsed.Value}");
        }

        static List<Token> Lex(string input)
        {
            var result = new List<Token>();

            for (int i=0; i < input.Length; i++)
            {
                switch(input[i])
                {
                    case '+':
                        result.Add(new Token(Token.Type.Plus, "+"));
                        break;
                    case '-':
                        result.Add(new Token(Token.Type.Minus, "-"));
                        break;
                    case '(':
                        result.Add(new Token(Token.Type.Lparen, "("));
                        break;
                    case ')':
                        result.Add(new Token(Token.Type.Rparen, ")"));
                        break;
                    default:
                        var sb = new StringBuilder(input[i].ToString());
                        for(int j = i + 1; j < input.Length; ++j)
                        {
                            if(char.IsDigit(input[j]))
                            {
                                sb.Append(input[j]);
                                ++i;
                            } 
                            else
                            {
                                result.Add(new Token(Token.Type.Integer, sb.ToString()));
                                break;
                            }
                        }
                        break;
                }
            }

            return result;
        }

        static IElement Parse(IReadOnlyList<Token> tokens)
        {
            var result = new BinaryOperation();
            bool haveLHS = false;
            for (int i = 0; i < tokens.Count; i++)
            {
                var token = tokens[i];

                // look at the type of token
                switch (token.MyType)
                {
                    case Token.Type.Integer:
                        var integer = new Integer(int.Parse(token.Text));
                        if (!haveLHS)
                        {
                            result.Left = integer;
                            haveLHS = true;
                        }
                        else
                        {
                            result.Right = integer;
                        }
                        break;
                    case Token.Type.Plus:
                        result.MyType = BinaryOperation.Type.Addition;
                        break;
                    case Token.Type.Minus:
                        result.MyType = BinaryOperation.Type.Subtraction;
                        break;
                    case Token.Type.Lparen:
                        int j = i;
                        for (; j < tokens.Count; ++j)
                            if (tokens[j].MyType == Token.Type.Rparen)
                                break; // found it!
                                       // process subexpression w/o opening (
                        var subexpression = tokens.Skip(i + 1).Take(j - i - 1).ToList();
                        var element = Parse(subexpression);
                        if (!haveLHS)
                        {
                            result.Left = element;
                            haveLHS = true;
                        }
                        else result.Right = element;
                        i = j; // advance
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            return result;
        }
    }
}
