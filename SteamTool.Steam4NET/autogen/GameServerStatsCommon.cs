// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(1800)]
	public struct GSStatsReceived_t
	{
		public const int k_iCallback = 1800;
		public EResult m_eResult;
		public SteamID_t m_steamIDUser;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(1801)]
	public struct GSStatsStored_t
	{
		public const int k_iCallback = 1801;
		public EResult m_eResult;
		public SteamID_t m_steamIDUser;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(1108)]
	public struct GSStatsUnloaded_t
	{
		public const int k_iCallback = 1108;
		public SteamID_t m_steamIDUser;
	};
	
}