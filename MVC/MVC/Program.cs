using System;

namespace MVC
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Model model = new Model();
            Controller controller = new Controller();
            var view = new View(model, controller);
            view.ShowName();
            view.ShowAge();
        }
    }
}
