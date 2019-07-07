using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeList : MonoBehaviour
{

    public void ListT(GameObject p1){
        p1.SetActive(true);
    }

    public void ListF(GameObject p1){
        p1.SetActive(false);
    }
}
