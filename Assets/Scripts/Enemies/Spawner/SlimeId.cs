using System.Collections;
using UnityEditor.Rendering;
using UnityEngine;

namespace Assets.Scripts.Enemies.Spawner
{
    [CreateAssetMenu(menuName = "Create SLimeId", fileName = "SlimeId", order = 0)]
    public class SlimeId : ScriptableObject
    {
        [SerializeField] private string _value;

        public string Value => _value;
    }
}