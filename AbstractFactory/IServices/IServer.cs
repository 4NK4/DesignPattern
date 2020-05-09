namespace FactoryPattern
{
    interface IServer
    {
        void Insert(User user);

        User GetUser(int id);
    }
}
