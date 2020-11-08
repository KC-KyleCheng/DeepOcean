using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    // Start is called before the first frame update
    public int moneyStatus = 50;
    public int fireStatus = 50;
    public int heartStatus = 50;
    public int groupStatus = 50;
    public Text MoneyStatusText;
    public Text fireStatusText;
    public Text heartStatusText;
    public Text groupStatusText;
    public Slider moneySlider;
    public Slider fireSlider;
    public Slider heartSlider;
    public Slider groupSlider;
    public Transform option;
    public Text option1Text;
    public Text option2Text;
    public Text option3Text;
    public Text option4Text;
    public Text caseText;
    int caseSwitch = 1; //for fun

    void Start()
    {
        option = GameObject.Find("ScriptsControl").GetComponent<Option>().option;
        moneySlider.value = (float)moneyStatus / 100;
        fireSlider.value = (float)fireStatus / 100;
        heartSlider.value = (float)heartStatus / 100;
        groupSlider.value = (float)groupStatus / 100;
    }

    // Update is called once per frame
    void Update()
    {
        MoneyStatusText.text = moneyStatus + "%";
        fireStatusText.text = fireStatus + "%";
        heartStatusText.text = heartStatus + "%";
        groupStatusText.text = groupStatus + "%";
        moneySlider.value = (float)moneyStatus / 100;
        fireSlider.value = (float)fireStatus / 100;
        heartSlider.value = (float)heartStatus / 100;
        groupSlider.value = (float)groupStatus / 100;
    }

    public void Enter()
    {
        transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);

    }
    public void Check()
    {
        if (Position.onTimeCard == null)
        {
            return;
        }

        if (Position.onTimeCard.GetComponent<CardsBehavior>().cardType == 0)
        {
            moneyStatus = moneyStatus + Random.Range(-15,16);
        }
        else if (Position.onTimeCard.GetComponent<CardsBehavior>().cardType == 1)
        {
            fireStatus = fireStatus + Random.Range(-15, 16);
        }
        else if (Position.onTimeCard.GetComponent<CardsBehavior>().cardType == 2)
        {
            heartStatus = heartStatus + Random.Range(-15, 16);
        }
        else if (Position.onTimeCard.GetComponent<CardsBehavior>().cardType == 3)
        {
            groupStatus = groupStatus + Random.Range(-15, 16);
        }
        Destroy(Position.onTimeCard);
        option.gameObject.SetActive(true);
        GameObject n = Instantiate(Resources.Load("Spade")) as GameObject;
        n.transform.SetParent(GameObject.Find("Cards").transform);
        
        switch (caseSwitch) //for fun
        {
            case 1:
                option1Text.text = "默默點了餐廳最貴的餐點送到她那，並附上親手寫的卡片表達心意";
                option2Text.text = "直接大喊「來當我媳婦吧！」";
                option3Text.text = "裝酷、沉默不語";
                option4Text.text = "派小弟上前攀談，並邀請到我們桌用餐";
                caseText.text = "在餐廳吃飯時，看到一個非常漂亮的女子走進來，完全就是老大的菜，這時老大會怎麼做?";
                break;
            case 2:
                option1Text.text = "我去跟隔壁的老王談談看，是不是能先借我們一些擋一擋";
                option2Text.text = "咱去搶軍火庫，幹一票大的!";
                option3Text.text = "看看帳戶裡還有多少錢，能買多少子彈先買多少";
                option4Text.text = "能怎麼辦? 快去賺錢想辦法生出來啊!";
                caseText.text = "大哥，經過上次與蓋幫的火拼，現在幫裡子彈幾乎見底，快不夠用了，該怎麼辦?";
                break;
            case 3:
                option1Text.text = "我再調查一下，別這麼快做決定";
                option2Text.text = "好啊，把幫裡最能幹的弟兄都叫上，今晚就出發！";
                option3Text.text = "叫幫裡2個最敏捷的小弟，趁晚上摸黑進行，安全為上";
                option4Text.text = "咱們幫派現在要做的是好好養精蓄銳，這票等我們有實力了以後再幹";
                caseText.text = "老大，有風聲傳來，路口那個銀行保險庫藏有大量金條，而且戒備不算森嚴，只要我們速戰速決，一定能在條子來之前逃之夭夭";
                break;
            case 4:
                option1Text.text = "讓幾個小弟帶點傢伙去，必要的話砸砸場子，嚇嚇他得了，看他還敢不敢繼續遲繳";
                option2Text.text = "去問問看老陳是不是經濟上遇到甚麼困難了吧，搞不好是我們能幫忙的";
                option3Text.text = "我現在沒心思管他，下個月再說吧";
                option4Text.text = "操！那我真要親眼看看這老陳到底在演哪齣戲。今晚把他壓到這來，我親自問他";
                caseText.text = "老陳在東區的夜店保護費已經遲繳3個月了，這個月的估計又繳不出來，老大，我們該怎麼做?";
                break;
            case 5:
                option1Text.text = "印点传单，出去拉人入会怎么样 ?";
                option2Text.text = "我们一起去打工吧！";
                option3Text.text = "你打算怎么作？";
                option4Text.text = "我身上还有一点买烟钱，拿去招点人吧。";
                caseText.text = "大哥，欢迎回归，现在帮派里只剩下我一个人镇守着等您回来，我一直相信您不会忘了我的。让我们再次一起重振我们帮派过去的辉煌把！";
                break;
        }
        if (caseSwitch < 5)
        {
            caseSwitch++;
        }
        else
        {
            caseSwitch = 1;
        }
    }
}
