using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using System;
using World.Block;

namespace World.Data
{
    /// <summary>
    /// ブロックのプレハブを持ってるクラス
    /// </summary>
    [CreateAssetMenu]
    public class BlockHolder : ScriptableObject
    {
        public BlockType type { get { return _holdType; } }
        [SerializeField] List<BuildBlock> blockPrefs;
        [SerializeField] BlockType _holdType;

        public BuildBlock GetBlock(int id)
        {
            try
            {
                return blockPrefs[id];
            }
                catch (IndexOutOfRangeException)
            {
                Debug.LogWarning("no block has id" + id);
                return blockPrefs[0];
            }
        }

        public int GetId(BuildBlock build)
        {
            return blockPrefs.IndexOf(build);
        }
    }
}