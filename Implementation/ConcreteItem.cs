using DesignPattern2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern2.Implementation
{
  
        public class ConcreteItem : IItem
        {
            private string name;
            private IPackage packing;
            private float price;

            // Private constructor to force the use of builder
            private ConcreteItem(string name, IPackage packing, float price)
            {
                this.name = name;
                this.packing = packing;
                this.price = price;
            }

            public string Name()
            {
                return name;
            }

            public IPackage Packing()
            {
                return packing;
            }

            public float Price()
            {
                return price;
            }

            // Builder implementation
            public class ItemBuilder : ItemBuilderBase<ItemBuilder>
            {
                public ConcreteItem Build()
                {
                    return new ConcreteItem(name, packing, price);
                }
            }
        }
    // Base class for Item builder
    public abstract class ItemBuilderBase<T> where T : ItemBuilderBase<T>
    {
        protected string name;
        protected IPackage packing;
        protected float price;

        public T SetName(string name)
        {
            this.name = name;
            return (T)this;
        }

        public T SetPacking(IPackage packing)
        {
            this.packing = packing;
            return (T)this;
        }

        public T SetPrice(float price)
        {
            this.price = price;
            return (T)this;
        }
    }

}

