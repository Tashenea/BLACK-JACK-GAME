using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardRemovedEventArgs : MonoBehaviour
{
   public int CardIndex { get; private set; }
    public CardRemovedEventArgs(int cardIndex)
    {
        CardIndex = cardIndex;
    }
}
