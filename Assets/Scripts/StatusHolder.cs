using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class StatusHolder : MonoBehaviour
{
    [SerializeField] TextMesh hp = null;
    [SerializeField] TextMesh status = null;
    public void SetHp(int current, int max)
    {
        hp.text = $"{current}/{max}";
    }
    public void SetStatus(Status status) { }
}
class Status
{

}