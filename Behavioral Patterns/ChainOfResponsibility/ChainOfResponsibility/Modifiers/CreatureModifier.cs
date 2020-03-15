using System;

namespace ChainOfResponsibility.Modifiers
{
    public class CreatureModifier
    {
        protected Creature creature;
        protected CreatureModifier next; //linked list

        public CreatureModifier(Creature creature)
        {
            this.creature = creature ?? throw new ArgumentNullException(paramName: nameof(creature));
        }

        public void Add(CreatureModifier creatureModifier)
        {
            if (next != null)
                next.Add(creatureModifier);
            else
                next = creatureModifier;
        }

        public virtual void Handle() => next?.Handle();
    }
}
