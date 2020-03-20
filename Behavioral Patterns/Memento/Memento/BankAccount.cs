﻿using System.Collections.Generic;

namespace Memento
{
    public class BankAccount
    {
        private int balance;
        private List<Memento> changes = new List<Memento>();
        private int current;

        public BankAccount(int balance)
        {
            this.balance = balance;
            changes.Add(new Memento(balance));
        }

        public Memento Deposit(int amount)
        {
            balance += amount;
            var memento = new Memento(balance);
            changes.Add(memento);
            ++current;
            return memento;
        }

        public Memento Restore(Memento memento)
        {
            if (memento != null)
            {
                balance = memento.Balance;
                changes.Add(memento);

                return memento;
            }

            return null;
        }

        public Memento Undo()
        {
            if (current > 0)
            {
                var memento = changes[--current];
                balance = memento.Balance;
                return memento;
            }
            return null;
        }

        public Memento Redo()
        {
            if(current + 1 < changes.Count)
            {
                var memento = changes[++current];
                balance = memento.Balance;
                return memento;
            }

            return null;
        }

        public override string ToString()
        {
            return $"{nameof(balance)}: {balance}";
        }
    }
}
