using Help.Numbers;
using System.Collections.Generic;

namespace Help.Roles
{
	/// <summary>
	/// Role
	/// </summary>
	public abstract class HelperRole
	{

		/// <summary>
		/// Acciones que se pueden aplicar sobre cada role
		/// </summary>
		/// 

		public struct Action
		{
			public const int READ		= 1;
			public const int CREATE		= 2;
			public const int EDIT		= 4;
			public const int DELETE		= 8;
			public const int PRINT		= 16;
			public const int EXECUTE	= 32;
			public const int TOLIST		= 64;
		}

		// ====================
		// Acctiones sobre ALGUNO los permisos
		// ====================


		/// <summary>
		/// Para una lista de roles y permisos, mira si todos tiene acceso para LIST
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanListAny( Dictionary<int, int> DirRoleAction, int[ ] arrRoles )
		{
			return CanAccessFor( DirRoleAction, arrRoles, false, Action.TOLIST );
		}

		/// <summary>
		/// Para una lista de roles y permisos, mira si  todos tiene acceso para EXECUTE
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanExecuteAny( Dictionary<int, int> DirRoleAction, int[ ] arrRoles )
		{
			return CanAccessFor( DirRoleAction, arrRoles, false, Action.EXECUTE );
		}

		/// <summary>
		/// Para una lista de roles y permisos, mira si todos tiene acceso para PRINT
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanPrintAny( Dictionary<int, int> DirRoleAction, int[ ] arrRoles )
		{
			return CanAccessFor( DirRoleAction, arrRoles, false, Action.PRINT );
		}

		/// <summary>
		/// Para una lista de roles y permisos, mira si todos tiene acceso para DELETE
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanDeleteAny( Dictionary<int, int> DirRoleAction, int[ ] arrRoles )
		{
			return CanAccessFor( DirRoleAction, arrRoles, false, Action.DELETE );
		}

		/// <summary>
		/// Para una lista de roles y permisos, mira si  todos tiene acceso para EDIT
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanEditAny( Dictionary<int, int> DirRoleAction, int[ ] arrRoles )
		{
			return CanAccessFor( DirRoleAction, arrRoles, false, Action.EDIT );
		}

		/// <summary>
		/// Para una lista de roles y permisos, mira si todos tiene acceso para CREAR
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanCreateAny( Dictionary<int, int> DirRoleAction, int[ ] arrRoles )
		{
			return CanAccessFor( DirRoleAction, arrRoles, false, Action.CREATE );
		}


		/// <summary>
		/// Para una lista de roles y permisos, mira si todos tiene acceso para LEER
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanReadAny( Dictionary<int, int> DirRoleAction, int[ ] arrRoles )
		{
			return CanAccessFor( DirRoleAction, arrRoles, false, Action.READ );
		}

		// ====================
		// Acctiones sobre TODOS los permisos
		// ====================

		/// <summary>
		/// Para una lista de roles y permisos, mira si todos tiene acceso para LIST
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanListAll( Dictionary<int, int> DirRoleAction, int[ ] arrRoles)
		{
			return CanAccessFor( DirRoleAction, arrRoles, true, Action.TOLIST );
		}

		/// <summary>
		/// Para una lista de roles y permisos, mira si  todos tiene acceso para EXECUTE
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanExecuteAll( Dictionary<int, int> DirRoleAction, int[ ] arrRoles )
		{
			return CanAccessFor( DirRoleAction, arrRoles, true, Action.EXECUTE );
		}

		/// <summary>
		/// Para una lista de roles y permisos, mira si todos tiene acceso para PRINT
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanPrintAll( Dictionary<int, int> DirRoleAction, int[ ] arrRoles )
		{
			return CanAccessFor( DirRoleAction, arrRoles, true, Action.PRINT );
		}

		/// <summary>
		/// Para una lista de roles y permisos, mira si todos tiene acceso para DELETE
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanDeleteAll( Dictionary<int, int> DirRoleAction, int[ ] arrRoles )
		{
			return CanAccessFor( DirRoleAction, arrRoles, true, Action.DELETE );
		}

		/// <summary>
		/// Para una lista de roles y permisos, mira si  todos tiene acceso para EDIT
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanEditAll( Dictionary<int, int> DirRoleAction, int[ ] arrRoles )
		{
			return CanAccessFor( DirRoleAction, arrRoles, true, Action.EDIT );
		}

		/// <summary>
		/// Para una lista de roles y permisos, mira si todos tiene acceso para CREAR
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanCreateAll( Dictionary<int, int> DirRoleAction, int[ ] arrRoles )
		{
			return CanAccessFor( DirRoleAction, arrRoles, true, Action.CREATE );
		}

		
		/// <summary>
		/// Para una lista de roles y permisos, mira si todos tiene acceso para LEER
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanReadAll( Dictionary<int, int> DirRoleAction, int[ ] arrRoles)
		{			
			return CanAccessFor( DirRoleAction, arrRoles, true, Action.READ );
		}

		
		// ==================
		// Acciones para un permiso
		// ====================

		/// <summary>
		/// Para una lista de roles y permisos, mira si un cierto role tiene permiso para LIST
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanList( Dictionary<int, int> DirRoleAction, int IdRole )
		{
			bool res = CanAccess( DirRoleAction, IdRole, Action.TOLIST );
			return res;
		}
		/// <summary>
		/// Para una lista de roles y permisos, mira si un cierto role tiene permiso para EXECUTE
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanExecute( Dictionary<int, int> DirRoleAction, int IdRole )
		{
			bool res = CanAccess( DirRoleAction, IdRole, Action.EXECUTE );
			return res;
		}

		/// <summary>
		/// Para una lista de roles y permisos, mira si un cierto role tiene permiso para PRINT
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanPrint( Dictionary<int, int> DirRoleAction, int IdRole )
		{
			bool res = CanAccess( DirRoleAction, IdRole, Action.PRINT );
			return res;
		}
		/// <summary>
		/// Para una lista de roles y permisos, mira si un cierto role tiene permiso para DELETE
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanDelete( Dictionary<int, int> DirRoleAction, int IdRole )
		{
			bool res = CanAccess( DirRoleAction, IdRole, Action.DELETE );
			return res;
		}

		/// <summary>
		/// Para una lista de roles y permisos, mira si un cierto role tiene permiso para EDIT
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanEdit( Dictionary<int, int> DirRoleAction, int IdRole )
		{
			bool res = CanAccess( DirRoleAction, IdRole, Action.EDIT );
			return res;
		}

		/// <summary>
		/// Para una lista de roles y permisos, mira si un cierto role tiene permiso para CREAR
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanCreate( Dictionary<int, int> DirRoleAction, int IdRole )
		{
			bool res = CanAccess( DirRoleAction, IdRole, Action.CREATE );
			return res;
		}


		/// <summary>
		/// Para una lista de roles y permisos, mira si un cierto role tiene permiso para leer
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="IdRole"></param>
		/// <returns></returns>
		public static bool CanRead( Dictionary<int, int> DirRoleAction, int IdRole )
		{
			bool res = CanAccess( DirRoleAction, IdRole, Action.READ );
			return res;
		}


		/// <summary>
		/// Indica si para un N roles (int) tiene una acción determinada, alguno de ellos o todos
		/// </summary>
		/// <param name="DirRoleAction"></param>
		/// <param name="arrRoles"></param>
		/// <param name="ForAllRoles"></param>
		/// <param name="IdAction"></param>
		/// <returns></returns>
		private static bool CanAccessFor( Dictionary<int, int> DirRoleAction, int[ ] arrRoles, bool ForAllRoles, int IdAction )
		{
			int NumRoles = arrRoles.Length;

			if( ForAllRoles ) {
				// Comprobar que tiene acceso de ACTION para todos los ROLES
				for( int i=0; i < NumRoles; i++ ) {
					if( !CanAccess( DirRoleAction, arrRoles[ i ], IdAction ) ) {
						return false;
					}
				}
				return true; // Tengo acceso a todos
			} else {
				// Comprobar que tiene acceso de ACTION a almenos a 1 ROLE
				for( int i=0; i < NumRoles; i++ ) {
					if( CanAccess( DirRoleAction, arrRoles[ i ], IdAction ) ) {
						return true; // Tiene acceso almenos a uno
					}
				}
				return false; // No tiene acceso a ninguno
			}

		}
		
		/// <summary>
		/// Indica si para un role (int) tiene una acción determinada.
		/// </summary>
		/// <param name="lst"></param>
		/// <param name="IdRole"></param>
		/// <param name="Action"></param>
		/// <returns></returns>
		private static bool CanAccess( Dictionary<int, int> dir, int IdRole, int IdAction )
		{
			if( null == dir || !dir.ContainsKey( IdRole ) ) {
				return false;
			}

			int Width = 8;
			string Binary = HelperNumber.ToBinaryString( dir[ IdRole ], Width );


			// 1   => 00000001 // Read
			// 2   => 00000010 // Create
			// 4   => 00000100 // Edit
			// 8   => 00001000 // Delete
			// 16  => 00010000 // Print
			// 32  => 00100000 // Execute
			// 64  => 01000000 // ToList
			// 128 => 10000000

			// IdAction valores 1,2,4,8,16,32,64,...
			int IdRoleToCheck = dir[ IdRole ];
			if( ( IdRoleToCheck & IdAction ) > 0 ) {
				return true;
			}
			return false;
		}

		
	}
}
