using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Image artworkImage; 
    public Card cardData;
    public UnityEngine.UI.Button button; 

    private void Awake()
    {
        // If you need to get the Image component on the GameObject this script is attached to:
        artworkImage = GetComponent<Image>();
        


        //button.onClick.AddListener(() => FindObjectOfType<DeckBuilder>().AddCardToDeck(cardData));
        
    }

    // Use this method to set up the card display with a specific card's data.
    public void Initialize(Card card, bool isSelectable)
    {
        cardData = card;
        Sprite artwork = Resources.Load<Sprite>("Cards_Artwork/" + card.cardName);
        artworkImage.sprite = artwork; // Assign the sprite to the artwork image.


        if (artwork == null)
    {
        Debug.LogError("Artwork not found for card: " + card.cardName);
    }
    else
    {
        artworkImage.sprite = artwork; // Assign the sprite to the artwork image.
    }
    

        button.onClick.RemoveAllListeners(); // Clear existing listeners
        if (isSelectable)
        {
        // If the card is in the available pool, clicking it will add it to the selected deck
        button.onClick.AddListener(() => FindObjectOfType<DeckBuilder>().AddCardToDeck(cardData));
        }
        else
        {
        // If the card is in the selected deck, clicking it will remove it from the selected deck
        button.onClick.AddListener(() => FindObjectOfType<DeckBuilder>().RemoveCardFromDeck(cardData));
        }
}

    // This method might be called elsewhere in your UI to update the card's display.
    public void Display(Card card)
    {
        cardData = card;
        Sprite artwork = Resources.Load<Sprite>("Cards_Artwork/" + card.cardName);
        artworkImage.sprite = artwork;
        
        // Additional display setup for card name, cost, etc., can go here if needed.
    }

    public void setActive(bool state)
    {
        gameObject.SetActive(state);
    }
    
}
