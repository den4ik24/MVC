using System;
namespace MVC
{
    public interface IModel
    {
        void Name();
        void Age();
        event EventHandler<TransferEventArgs> Notify;
    }

    public class Model : IModel
    {
        public event EventHandler<TransferEventArgs> Notify;
        public Model()
        {
        }

        public void Name()
        {
            var name = "Guru";
            var transfer = new TransferEventArgs
            {
                Name = name,
                TypeTransfer = TypeTransfer.NAME
            };
            Notify?.Invoke(this, transfer);
        }

        public void Age()
        {
            var age = 111;
            var transfer = new TransferEventArgs
            {
                Age = age,
                TypeTransfer = TypeTransfer.AGE
            };
            Notify?.Invoke(this, transfer);
        }
    }

    public class TransferEventArgs : EventArgs
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public TypeTransfer TypeTransfer { get; set; }
    }


    public enum TypeTransfer
    {
        NAME,
        AGE
    }

}
