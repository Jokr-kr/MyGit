
namespace ConsoleCollection.FriendFace
{
    internal class User
    {
        private string? _name { get; }
        private string? _hobby { get; set; }
        private Friends _friends { get; set; }
        
        public User(string? name, string? hobby)
        {
            _name = name;
            _hobby = hobby;
            _friends=new Friends();
        }

        //------methods to interact with User variables------//
        //--returning only the name--//
        internal string GetName()
        {
            return _name!;
        }
        //-------returning the name and hobby-----//
        //(mostly just wanted to learn returning two variables)//
        internal (string?, string?) GetProfile()
        {
            return (_name, _hobby);
        }

        //only returning hobby is not needed for this assignment//

        //-------methods for the _friends object-------//
        internal void Removefriend(User Friend)
        {
           _friends.Remove(Friend);
        }
        internal void Addfriend(User NewFriend)
        {
            _friends.Addf(NewFriend);
        }
        //i think probably these two methods can be combined as the foreach can be done ouside the object
        //but for now it stays in to help indicate progress
        internal List<User> Friendlist()
        {
            return _friends.Getlist();
        }

        internal void ShowFriends()
        {
            foreach (var friend in _friends.Getlist())
            {
                Console.WriteLine($"{friend._name}");
            }
        }
    }
}
