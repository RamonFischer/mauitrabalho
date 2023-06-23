package crc640f21664b25709b84;


public class MainActivity
	extends crc6488302ad6e9e4df1a.MauiAppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Projeto_Curso.MainActivity, Projeto_Curso", MainActivity.class, __md_methods);
	}


	public MainActivity ()
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("Projeto_Curso.MainActivity, Projeto_Curso", "", this, new java.lang.Object[] {  });
	}


	public MainActivity (int p0)
	{
		super (p0);
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("Projeto_Curso.MainActivity, Projeto_Curso", "System.Int32, System.Private.CoreLib", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
