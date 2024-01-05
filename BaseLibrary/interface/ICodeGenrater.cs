namespace BaseLibrary.Interface
{
	public interface ICodeGenerator<T, U> where T : class where U : class
	{
		U CreateData();	
	}
}
