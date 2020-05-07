using Data;
using Photon.Pun;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Networking
{
    public class GameManager : MonoBehaviourPunCallbacks
    {
        [SerializeField] private GameObject playerPrefab;

        [SerializeField] private Transform playerStartPoint;

        [SerializeField] private SettingsData settings;

        // Start is called before the first frame update
        void Start()
        {
            if (settings.playerName == null)
                Instantiate(playerPrefab, playerStartPoint.position, playerStartPoint.rotation);
            else
                PhotonNetwork.Instantiate(playerPrefab.name, playerStartPoint.position, playerStartPoint.rotation);
        }

        // Update is called once per frame
        void Update()
        {
        }

        public void OnLeftRoom()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}