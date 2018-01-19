namespace Algorithms.Interfaces
{
	interface ICommon<E>
	{
        bool Empty();
		E First();
		E Last();
		E Retrive(E obj);
        void ClearCollection();
    }
}
