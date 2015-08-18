using UnityEngine;
using System.Collections;
using Parse;

public class CriarUsuarioParse : MonoBehaviour {

	[SerializeField] private string usuario, pwd, email;
	[SerializeField] private int scoreInicial;
	// Use this for initialization
	void Start () {
        CreateUser();
    }

    void CreateUser()
    {

        var user = new ParseUser()
        {
            Username = usuario,
            Password = pwd,
            Email = email
        };

        // other fields can be set just like with ParseObject
        user["pontuacao"] = (int) scoreInicial;

        user.SignUpAsync().ContinueWith( t => {
            if (t.IsFaulted || t.IsCanceled)
            {
                Debug.Log("Login Fail");
            }
            else
            {
                // Login was successful
               
                Debug.Log(t.ToString());
                //                string email;
                //                user.TryGetValue<string>("score", out email);
                //            Debug.Log(email );
            }
        }); 
        
        

    }
}
