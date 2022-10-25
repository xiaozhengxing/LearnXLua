using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class TestMono : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        XLua.LuaEnv luaEnv = new XLua.LuaEnv();
        luaEnv.DoString("CS.UnityEngine.Debug.Log(CS.UnityEngine.Vector3.kEpsilon)");
        luaEnv.DoString("CS.TestAAA.TestFunc()");
        
        luaEnv.Dispose();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static public void TestFunc()
    {
        UnityEngine.Debug.Log("xzx TestMono.TestFunc");
    }
}

public class TestAAA: TestMono
{
    public int x = 888;
    private int y = 999;
    public int Func1() { return 100; }
}