using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destroyVFX;
    [SerializeField] int hitpoints = 3;
    [SerializeField] int scoreValue = 10;

    ScoreBoard scoreBoard;

    private void Start() {
        scoreBoard = FindFirstObjectByType<ScoreBoard>();
    }

    private void OnParticleCollision(GameObject other) {
        processDestroy();
    }

    private void processDestroy(){
        hitpoints --;

        if (hitpoints <= 0) {
        scoreBoard.increaseScore(scoreValue);
        Instantiate(destroyVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
        }

    }

}
