using System.Transactions;

namespace Help.Transactions
{
	/// <summary>
	/// Descripción breve de FactoryTransaction
	/// </summary>
	public static partial class HelperTransaction
	{
		public static TransactionScope CreateScope( )
		{
			// Si no esta activado
			// ALTER DATABASE [eTRANSNET21] SET ALLOW_SNAPSHOT_ISOLATION ON
			TransactionOptions transactionOptions = new TransactionOptions( ) {
				//IsolationLevel = System.Transactions.IsolationLevel.Snapshot,
				Timeout = TransactionManager.MaximumTimeout
			};

			return new TransactionScope( TransactionScopeOption.Required, transactionOptions );
		}
	}
}