using System;
namespace MVC
{
    public interface IController
    {
        void AddName(IModel imodel);
        void AddAge(IModel imodel);
    }

    public class Controller: IController
    {
        public Controller()
        {
        }

        public void AddName(IModel imodel)
        {
            imodel.Name();
        }

        public void AddAge(IModel imodel)
        {
            imodel.Age();
        }
    }
}
