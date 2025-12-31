using UnityEngine;

namespace PGS
{
    public abstract class SystemService : MonoBehaviour
    {
        public virtual void SetupService()
        {
            GameManager.RegisterSystemService(this);
        }
    }
}
