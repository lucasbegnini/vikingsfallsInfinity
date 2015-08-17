using UnityEngine;
using System.Collections;
using Parse;
public class Teste : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ParseObject testObject = new ParseObject("TestObject");
        testObject["tipo do Obj"] = "Mensagem";
        testObject.SaveAsync();

    }

}
