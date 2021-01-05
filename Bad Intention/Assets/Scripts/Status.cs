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

    //int[] optionHeart = new int[4];
    //int[] optionDimond = new int[4];
    //int[] optionSpade = new int[4];
    //int[] optionClub = new int[4];
    public int[] optionHeart;
    public int[] optionDimond;
    public int[] optionSpade;
    public int[] optionClub;
    public int random0;

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
    //0 for Club(梅花), 1 for Dimond(方片), 2 for Heart(红桃), 3 for Spade(黑桃)
    //money 0 金钱，fire 1 士气，heart 2 生命， group 4 人数
    public void Check()
    {   


        //cases
        switch (caseSwitch) //for fun
        {
            case 1:
                option1Text.text = "印点传单，出去拉人入会怎么样?";
                option2Text.text = "我们一起去打工吧！";
                option3Text.text = "你打算怎么作？";
                option4Text.text = "我身上还有一点买烟钱，拿去招点人吧。";
                caseText.text = "大哥，现在帮派里要钱没钱，要人没人，您第一步有什么打算吗？";

                optionHeart = new int[] { -10, -10, 0, 0 };
                optionDimond = new int[] { 10, 0, 0, 0 };
                optionSpade = new int[] { -10, -10, -10, -10 };
                optionClub = new int[] { -10, 0, 0, 10 };
                break;
            case 2:
                option1Text.text = "听听她为什么想加入先吧。";
                option2Text.text = "交了会费随便加入！";
                option3Text.text = "这种小事你处理就好。";
                option4Text.text = "都什么年代了，帮派还能有性别歧视的？";
                caseText.text = "大哥，有个女孩说非得加入我们帮派，但是我们不收女孩，怎么办？";

                random0 = Random.Range(0, 2);
                optionHeart = new int[] { 0, 10, 0, 0 };
                optionDimond = new int[] { 10, 0, 0, 10 };
                if (random0 == 1)
                {
                    optionSpade = new int[] { -15, -15, -15, -15 };
                }
                else
                {
                    optionSpade = new int[] { 10, 0, 0, 10 };
                }
                if (random0 == 1)
                {
                    optionClub = new int[] { 0, 0, 0, 10 };
                }
                else
                {
                    optionClub = new int[] { -15, 0, 0, 0 };
                }
                break;
            case 3:
                option1Text.text = "以后大妈们跳广场舞的时候就派你去负责占场地！";
                option2Text.text = "给带头的大妈包个红包，让他们自己斗去吧。";
                option3Text.text = "很好！让他们知道这地方的主人是谁！";
                option4Text.text = "兄弟们，一定是我们没有好好的服务到我们的民众！今天全体出去做道路清洁！";
                caseText.text = "大哥，社区的大妈在我们会门口拿着扫把抗议，说我们天天黑衣黑裤，像是黑涩会，他们担心小孩会学坏！";

                optionHeart = new int[] { 0, 0, 0, 10 };
                optionDimond = new int[] { -30, 0, 10, 0 };
                optionSpade = new int[] { -15, 0, -15, 15 };
                optionClub = new int[] { -30, 0, 0, 10 };
                //////end///////
                break;
            case 4:
                option1Text.text = "哪有做父亲的不能原谅自己孩子的说法？";
                option2Text.text = "进江湖容易，出江湖难！让他把欠的先补上再说！";
                option3Text.text = "送他一拳然后把他轰走！";
                option4Text.text = "这件事不是我一个人的事情，兄弟们决定就好。";
                caseText.text = "大哥，以前背叛您的兄弟现在哭着跑回来说他很对不起您，我们应该怎么办？";

                optionHeart = new int[] { 0, 0, 0, 10 };
                optionDimond = new int[] { -30, 0, 10, 0 };
                optionSpade = new int[] { -15, 0, -15, 15 };
                optionClub = new int[] { -30, 0, 0, 10 };
                break;
            case 5:
                option1Text.text = "帮我约一下与他们老大见面。";
                option2Text.text = "钱能解决吗？";
                option3Text.text = "天地难容，兄弟们！是时候干一票了！";
                option4Text.text = "派一组人马过去他们总部警告一下。";
                caseText.text = "大哥，隔壁帮派的人最近有点嚣张，居然来我们地盘拉人加入他们，我们该怎么办？";

                optionHeart = new int[] { 0, 0, 0, 10 };
                optionDimond = new int[] { -30, 0, 10, 0 };
                optionSpade = new int[] { -15, 0, -15, 15 };
                optionClub = new int[] { -30, 0, 0, 10 };
                break;
        }












        ///////////for fun///////////////////

        if (caseSwitch < 5)
        {
            caseSwitch++;
        }
        else
        {
            caseSwitch = 1;
        }

        ///////////for fun///////////////////





















        //0 for Club(梅花), 1 for Dimond(方片), 2 for Heart(红桃), 3 for Spade(黑桃)
        //money 0 金钱，fire 1 士气，heart 2 生命， group 4 人数
        //options



        if (Position.onTimeCard == null)
        {
            return;
        }

        if (Position.onTimeCard.GetComponent<CardsBehavior>().cardType == 0)
        {
            moneyStatus = moneyStatus + optionClub[0];
            fireStatus = fireStatus + optionClub[1];
            heartStatus = heartStatus + optionClub[2];
            groupStatus = groupStatus + optionClub[3];
        }
        else if (Position.onTimeCard.GetComponent<CardsBehavior>().cardType == 1)
        {
            moneyStatus = moneyStatus + optionDimond[0];
            fireStatus = fireStatus + optionDimond[1];
            heartStatus = heartStatus + optionDimond[2];
            groupStatus = groupStatus + optionDimond[3];
        }
        else if (Position.onTimeCard.GetComponent<CardsBehavior>().cardType == 2)
        {
            moneyStatus = moneyStatus + optionHeart[0];
            fireStatus = fireStatus + optionHeart[1];
            heartStatus = heartStatus + optionHeart[2];
            groupStatus = groupStatus + optionHeart[3];
        }
        else if (Position.onTimeCard.GetComponent<CardsBehavior>().cardType == 3)
        {
            moneyStatus = moneyStatus + optionSpade[0];
            fireStatus = fireStatus + optionSpade[1];
            heartStatus = heartStatus + optionSpade[2];
            groupStatus = groupStatus + optionSpade[3];
        }


        if (moneyStatus > 100)
        {
            moneyStatus = 100;
        }
        if (moneyStatus < 0)
        {
            moneyStatus = 0;
        }
        if (fireStatus > 100)
        {
            fireStatus = 100;
        }
        if (fireStatus < 0)
        {
            fireStatus = 0;
        }
        if (heartStatus > 100)
        {
            heartStatus = 100;
        }
        if (heartStatus < 0)
        {
            heartStatus = 0;
        }
        if (groupStatus > 100)
        {
            groupStatus = 100;
        }
        if (groupStatus < 0)
        {
            groupStatus = 0;
        }

        Destroy(Position.onTimeCard);
        option.gameObject.SetActive(true);
        GameObject n = Instantiate(Resources.Load("Spade")) as GameObject;
        n.transform.SetParent(GameObject.Find("Cards").transform);


        


    }
}
