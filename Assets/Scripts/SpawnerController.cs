using System.Collections;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private Vector2 _range;
    [SerializeField] private GameObject _witcherSheild;
    [SerializeField] private GameObject _witcher;

    private void Start()
    {
        StartCoroutine(SpawnWitcherShield());
        StartCoroutine(SpawnWitcher());
    }
    private IEnumerator SpawnWitcherShield()
    {
        yield return new WaitForSeconds(1);
        Vector2 spawnPos =
            transform.position + new Vector3(0, Random.Range(-_range.y, _range.y));
        Instantiate(_witcherSheild, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnWitcherShield());
    }
    private IEnumerator SpawnWitcher()
    {
        yield return new WaitForSeconds(1.5f);
        Vector2 spawnPos =
            transform.position + new Vector3(0, Random.Range(-_range.y, _range.y));
        Instantiate(_witcher, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnWitcher());
    }
}
