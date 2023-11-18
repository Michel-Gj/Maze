using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //audioSource.PlayOneShot(shooting);
            Shot();
        }
    }

    public void Shot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);

        //ammo--;
        //bulletImages[ammo].SetActive(false);
        if (hit.collider.gameObject.tag.StartsWith("Enemy"))
        {
            //EnemyBehaviour temp = hit.collider.gameObject.GetComponent<EnemyBehaviour>();
            //if (temp.lifepoints - 1 <= 0)
            //{
            //    waveManager.UpdateEnemyOut(-1);
            //}
            //temp.ChangeLifepoints(-1);
            Destroy(hit.collider.gameObject);

        }
    }
}
