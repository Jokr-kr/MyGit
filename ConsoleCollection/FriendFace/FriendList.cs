
namespace ConsoleCollection.FriendFace
{
    //i think its a better choice to just have a list directly in the User object instead of making it into its own Class.
    //but i want to nest objects to get a feel for it. and this is on scale i think i can manage.

    //-----------------just a list-------------------//
    internal class Friends
    {
        private List<User> _list { get; } = new();


    //--------methods allowed to use on list---------//
            //--------------add-------------//
        internal void Addf(User NewFriend)
        {
        _list.Add(NewFriend);
        }
            //-------------remove-----------//
        internal void Remove(User Friend)
        {
            _list.Remove(Friend);
        }
            //-------------view--------------//
        internal List<User> Getlist()
        {
            return _list;
        }
    }
}
