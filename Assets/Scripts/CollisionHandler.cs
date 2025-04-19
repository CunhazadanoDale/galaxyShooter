using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject playerExplosion;

    GameSceneManager gameSceneManager;

    private void OnTriggerEnter(Collider other) {
        gameSceneManager.ReloadLevel();
        Instantiate (playerExplosion, transform.position, Quaternion.identity);
        Destroy(gameObject);    
    }
}
