using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp : MonoBehaviour
{
    static Temp Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void temporal()
    {

    }

    void Dot()
    {
        // Aqui se crearia un nuevo temp, esto no se quiere en un singleton
        //Temp _temp = new Temp();

        // Para tener acceso universal para el signleton se utiliza Temp.Instance
    }
}
