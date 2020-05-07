using Core;
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

        [SerializeField] private GameProxy gameProxy;

        private GameObject t;

        // Start is called before the first frame update
        void Start()
        {
            if (settings.playerName == null)
            {
                t = Instantiate(playerPrefab, playerStartPoint.position, playerStartPoint.rotation);
            }
            else
            {
                t = PhotonNetwork.Instantiate(playerPrefab.name, playerStartPoint.position, playerStartPoint.rotation);
            }
            gameProxy.allies.Add(t);
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