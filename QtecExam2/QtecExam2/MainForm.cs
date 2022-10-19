using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QtecExam2
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private Storage myStorage;
        public Espresso espresso = new Espresso();
        public Latte latte = new Latte();
        public Americano ameri = new Americano();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 초기재료 셋팅.
            myStorage = new Storage();
        }

        #region Button Event

        private void btnIngredient_Click(object sender, EventArgs e)
        {
            PrintList(myStorage, 0);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            PrintList(myStorage, 1);
        }

        private void btnEspresso_Click(object sender, EventArgs e)
        {
            if (espresso.Purchase(myStorage))
            {
                PrintList(myStorage, 2);
                myStorage.EsprCnt++;
            }
            else
            {
                labelText.Text = "Fail";
                SetText("재료가 부족합니다.");
            }
        }

        private void btnLatte_Click(object sender, EventArgs e)
        {
            if (latte.Purchase(myStorage))
            {
                PrintList(myStorage, 2);
                myStorage.LatteCnt++;
            }
            else
            {
                labelText.Text = "Fail";
                SetText("재료가 부족합니다.");
            }
        }

        private void btnAmericano_Click(object sender, EventArgs e)
        {
            if (ameri.Purchase(myStorage))
            {
                PrintList(myStorage, 2);
                myStorage.AmeriCnt++;
            }
            else
            {
                labelText.Text = "Fail";
                SetText("재료가 부족합니다.");
            }
        }

        #endregion 

        // type 0 : 재료보고, 1 : 메뉴 선택, 2 : 제품 사용
        private void PrintList(Storage myStore, int type, Products product = null)
        {
            listContent.Items.Clear();
            labelText.Text = "";

            switch (type)
            {
                    // 재료보고
                case 0:
                    {
                        listContent.Items.Add(string.Format("{0,-5}:{1,10}{2,2}", "커피", myStore.Coffee,"g"));
                        listContent.Items.Add(string.Format("{0,-5}:{1,10}{2,2}", "물", myStore.Water,"ml"));
                        listContent.Items.Add(string.Format("{0,-5}:{1,10}{2,2}", "우유", myStore.Milk,"ml"));

                        labelText.Text = "재료 보고";
                    }
                    break;
                    // 정산 보고
                case 1:
                    listContent.Items.Add(string.Format("{0,-10} {1,10} {2,2}","총 수익금 :", myStore.Money, "원"));
                    listContent.Items.Add("");
                    listContent.Items.Add(string.Format("{0,-10} {1,4} {2,2} {3,10} {4,2}", "에스프레소 합계 :", myStore.EsprCnt, "잔", myStore.EsprCnt * espresso.cost, "원"));
                    listContent.Items.Add(string.Format("{0,-10} {1,4} {2,2} {3,10} {4,2}", "라떼 합계 :", myStore.LatteCnt, "잔", myStore.LatteCnt * latte.cost, "원"));
                    listContent.Items.Add(string.Format("{0,-10} {1,4} {2,2} {3,10} {4,2}", "아메리카노 합계 :", myStore.AmeriCnt, "잔", myStore.AmeriCnt * ameri.cost, "원"));

                    labelText.Text = "정산 보고";
                    break;
                    // 메뉴 판매
                case 2:
                    labelText.Text = "OK";
                    break;
            }
        }

        private void SetText(string text)
        {
            listContent.Items.Clear();
            listContent.Items.Add(text);
        }
    }

    // 자판기 저장소 클래스
    public class Storage
    {
        private int m_iMoney;

        public int Money
        {
            get { return m_iMoney; }
            set { m_iMoney = value; }
        }

        private int m_iCoffee;

        public int Coffee
        {
            get { return m_iCoffee; }
            set { m_iCoffee = value; }
        }

        private int m_iWater;

        public int Water
        {
            get { return m_iWater; }
            set { m_iWater = value; }
        }

        private int m_iMilk;

        public int Milk
        {
            get { return m_iMilk; }
            set { m_iMilk = value; }
        }

        private int m_EsprCnt;

        public int EsprCnt
        {
            get { return m_EsprCnt; }
            set { m_EsprCnt = value; }
        }

        private int m_LattCnt;

        public int LatteCnt
        {
            get { return m_LattCnt; }
            set { m_LattCnt = value; }
        }

        private int m_AmerCnt;

        public int AmeriCnt
        {
            get { return m_AmerCnt; }
            set { m_AmerCnt = value; }
        }



        public Storage() 
        {
            Money = 0;
            Coffee = 10000;
            Water = 10000;
            Milk = 5000;

            EsprCnt = 0;
            LatteCnt = 0;
            AmeriCnt = 0;
        }
    }
}
