using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerProgress : MonoBehaviour
{
    public List<PlayerProgressLevel> levels;
    //Для этого, как обычно, понадобится ссылка на соответствующий объект интерфейса.
    //В нашем случае — на компонент TextMeshProUGUI. Добавь публичное поле и назови его levelValueTMP.
    public TextMeshProUGUI levelValueTMP;
    //Изменить эту координату нужно внутри метода DrawUI, поэтому нам понадобится ссылка на компонент RectTransform жёлтого прямоугольника
    //(шкалы опыта). Для этого создадим публичное поле и назовём его experienceValueRectTransform.
    public RectTransform experienceValueRectTransform;
    //Заведём приватное поле типа int и назовём его _levelValue.
    //Это поле будет отвечать за значение уровня игрока.
    //На старте игры уровень равен одному.
    private int _levelValue = 1;
    //Заведи два приватных поля типа float и назови их _experienceCurrentValue (для текущих очков опыта)
    //и _experienceTargetValue (для очков, необходимых, чтобы перейти на следующий уровень).
    //В значениях по умолчанию укажи 0 для первого и 100 для второго.
    private float _experienceCurrentValue = 0;
    private float _experienceTagetValue = 100;



    // Start is called before the first frame update
    private void Start()
    {
        SetLevel(_levelValue);
        DrawUI();
    }
    public void AddExperience(float value)
    {
        _experienceCurrentValue += value;
        if(_experienceCurrentValue >= _experienceTagetValue)
        {            
            _experienceCurrentValue -= _experienceTagetValue;
            SetLevel(_levelValue += 1);
        }
        DrawUI();
    }

    private void SetLevel(int value)
    {
        _levelValue = value;

        _experienceTagetValue = levels[_levelValue - 1].experieneceForTheNextLevel;
    }
    // Update is called once per frame
    private void DrawUI()
    {
        experienceValueRectTransform.anchorMax = new Vector2(_experienceCurrentValue / _experienceTagetValue, 1);
        levelValueTMP.text = _levelValue.ToString();
    }
}
