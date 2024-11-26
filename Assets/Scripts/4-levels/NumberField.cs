using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

/**
 * This component should be attached to a TextMeshPro object.
 * It allows to feed an integer number to the text field.
 */
[RequireComponent(typeof(TextMeshPro))]
public class NumberField : MonoBehaviour {
    private int number;
    [Tooltip("Put here you score player text")]
    public TextMeshProUGUI scoreText; // Reference to the TextMeshProUGUI component for displaying the score

    public int GetNumber() {
        return this.number;
    }

    public void SetNumber(int newNumber) {
        this.number = newNumber;
        GetComponent<TextMeshPro>().text = newNumber.ToString();
        scoreText.text = $"Score: {newNumber}";//for score view (Top screen)
    }

    public void AddNumber(int toAdd) {
        SetNumber(this.number + toAdd);
    }
}


/**
 * 2.	הניקוד של השחקן לא מוצג מעל החללית, אלא במקום קבוע על המסך, למשל בפינה הימנית-עליונה. 
 * יש לבדוק שהניקוד מוצג במקום הנכון גם כשגודל המסך משתנה, כשהמסך מסתובב וכו'.
 * רמז: השתמשו ב Canvas. 
 */