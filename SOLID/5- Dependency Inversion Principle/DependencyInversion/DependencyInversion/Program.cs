﻿using System;

namespace DependencyInversion
{
    /// <summary>
    /// "One should depend upon abstractions, not concretions."
    /// 
    /// Research class depends upon abstraction(IRelationshipBrowser interface),
    /// not upon concretion(Relationships class).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Chris" };
            var child2 = new Person { Name = "Mary" };

            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            new Research(relationships);
        }
    }
}
