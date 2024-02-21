using DesignPattern.ChainOfResponsibilty.DAL;

namespace DesignPattern.ChainOfResponsibilty.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextAprover;
        public void SetNextAprover(Employee SuperVisor)
        {
            NextAprover = SuperVisor;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel req);
    }
}
