using RPGM.Core;
using RPGM.Gameplay;
using RPGM.UI;
using UnityEngine;


namespace RPGM.Gameplay
{
    /// <summary>
    /// Marks a gameObject as a collectable item.
    /// </summary>
    [ExecuteInEditMode]
    [RequireComponent(typeof(SpriteRenderer), typeof(BoxCollider2D))]
    public class InventoryItem : MonoBehaviour
    {
        public int count = 1;
        public Sprite sprite;

        GameModel model = Schedule.GetModel<GameModel>();

        //void Reset()
        //{
        //    GetComponent<BoxCollider2D>().isTrigger = true;
        //}

        void OnEnable()
        {
            GetComponent<SpriteRenderer>().sprite = sprite;
        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            MessageBar.Show($"You collected: {name} x {count}");
            model.AddInventoryItem(this);
            UserInterfaceAudio.OnCollect();
            gameObject.SetActive(false);
        }
    }
}