using System;
namespace MVC
{
    public interface IView
    {
        void ShowName();
        void ShowAge();
        void ShowMessage(object sender, TransferEventArgs e);
    }

    public class View : IView
    {
        IController icontroller;
        IModel imodel;
        public View(Model model, Controller controller)
        {
            imodel = model;
            icontroller = controller;
            imodel.Notify += ShowMessage;
        }

        public void ShowName()
        {
            icontroller.AddName(imodel);
        }

        public void ShowAge()
        {
            icontroller.AddAge(imodel);
        }

        public void ShowMessage(object sender, TransferEventArgs e)
        {
            if(e.TypeTransfer == TypeTransfer.NAME)
            {
                Console.WriteLine($"The name of your teacher is {e.Name}");
            }
            if(e.TypeTransfer == TypeTransfer.AGE)
            {
                Console.WriteLine($"The age of your teacher is {e.Age}");
            }
        }
    }
}
