using LoginRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginRegistration.ViewModels
{


    public class AcerModel
    {
        public List<Acer> Acers { get; set; }
        public List<Acer> findAll()
        {
            Acers = new List<Acer> {

                //Swift
                new Acer()
               {
                Id="1",
                Name="Swift 3 AMD",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Swift_3/Image/20200416/Acer-Swift-3_SF314-42_Silver-FP-Backlit_modelpreview.png",
                Price= 115000
               },
                new Acer()
               {
                Id="2",
                Name="Swift 3X",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Swift_3X/Images/20201008/Acer-Swift-3X_SF314-510G_Gold_modelpreview.png",
                Price= 60000
               },
                 new Acer()
               {
                Id="3",
                Name="Swift 7",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Swift_7/Image/20190226/swift_7_SF714-52T-Black-Budlight_AL_preview.png",
                Price=187000
               },
                 new Acer()
               {
                Id="4",
                Name="Swift 5",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Swift_5/Image/20200707/Acer-Swift-5_SF514-55_FP_Green_modelpreview.png",
                Price= 109922
               },
                 new Acer()
               {
                Id="5",
                Name="Swift 3",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Swift_3/Image/20200922/Acer-Swift-3_SF314-59_FP-Backlit_Silver_modelpreview.png",
                Price= 89700
               },
                 new Acer()
               {
                Id="6",
                Name="Swift 1",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Swift_1/Image/20200707/Acer-Swift-1_SF114-33_Gold_modelpreview.png",
                Price= 160000
               },
                 new Acer()
               {
                Id="7",
                Name="Swift 1 XS",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Swift_1/Image/20200707/Acer-Swift-1_SF114-33_Gold_modelpreview.png",
                Price= 150000
               },
                 new Acer()
               {
                Id="8",
                Name="Swift 5A",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Swift_5/Image/20200707/Acer-Swift-5_SF514-55_FP_Green_modelpreview.png",
                Price= 100000
               },
             


                 //Spin

                 new Acer()
               {
                Id="9",
                Name="Spin 5 (2020)",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Spin_5/Image/20201021/Acer-Spin-5_-SP513-55N-55NA_FP-Backlit_Steel-Gray_modelpreview.png",
                Price= 90000
               },
                 new Acer()
               {
                Id="10",
                Name="Swift 7 (2021)",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Spin_7/image/20201207/Acer-Spin-7_%20SP714-61NA_FP-Backlit_Blue_modelpreview.png",
                Price= 250000
               },
                 new Acer()
               {
                Id="11",
                Name="Spin 7",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Spin_7/image/20201207/Acer-Spin-7_%20SP714-61NA_FP-Backlit_Blue_modelpreview.png",
                Price= 210000
               },
                 new Acer()
               {
                Id="12",
                Name="Spin 5",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Spin_5/Image/20201021/Acer-Spin-5_-SP513-55N-55NA_FP-Backlit_Steel-Gray_modelpreview.png",
                Price= 88000
               },
                new Acer()
               {
                Id="13",
                Name="Spin 3",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Spin_3/Image/20210323/Acer-Spin-3_SP313-51N_FP-non-Backlit_Silver_modepreview.png",
                Price= 120000
               },
                 new Acer()
               {
                Id="14",
                Name="Spin 1",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Spin_1/Image/20210227/Spin-1-SP114-31-Bl-Sv_modelpreview.png",
                Price=72000
               },


                 //Aspire
                 new Acer()
               {
                Id="15",
                Name="Aspire 7",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Aspire_7/images/20201216/Aspire7_A715-42G_FpBl_Bk_modelrpeview.png",
                Price= 120000
               },
                 new Acer()
               {
                Id="16",
                Name="Aspire 5",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Aspire_5/images/20210106/Aspire5_A515-45-46_FpBl_Sv_modelpeview.png",
                Price= 61000
               },
                 new Acer()
               {
                Id="17",
                Name="Aspire 3",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Aspire_3/images/20201001/1/Acer-Aspire-3-A315-56-Steel-Grey-modelpreview.png",
                Price= 79000
               },
                 new Acer()
               {
                Id="18",
                Name="Aspire 1",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Aspire_1/images/20210205/Acer-Aspire-1_A115-22_modelpreview.png",
                Price= 22000
               },



                 //nitro
                 new Acer()
               {
                Id="19",
                Name="Nitro 7",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Nitro_7/Images/20200703/Acer-Nitro-7_AN715-52_RGB-KB_modelpreview.png",
                Price= 165000
               },
                 new Acer()
               {
                Id="20",
                Name="Nitro 5",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Nitro_5/Image/20210106/Nitro5_AN515-56_Bl_Bk_modelpreview.png",
                Price= 132000
               },
                 new Acer()
               {
                Id="21",
                Name="Nitro 5 AMD",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Nitro_5/Image/20210111/Nitro-5-AN517-41-modelpreview.png",
                Price= 125000
               },
                 new Acer()
               {
                Id="22",
                Name="Nitro 5 Spin",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Nitro_5_Spin/Image/20170823/nitro_5_spin_NP515-51_preview.png",
                Price= 143000
               },


                 //Chromebook
                new Acer()
               {
                Id="23",
                Name="Acer Chromebook 311 (C722)",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_311/rev-jan-2021/20210120/Acer_Chromebook-311_C722-C722T_modelpreview.png",
                Price= 29000
               },
                 new Acer()
               {
                Id="24",
                Name="Acer Chromebook 511 (C741L)",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_511_/rev-jan-2021/20210222/Chromebook-511-C741L-Bk_modelpreview.png",
                Price= 58000
               },
                 new Acer()
               {
                Id="25",
                Name="Acer Chromebook Spin 511 (R753T)",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/acer-chromebook-spin-511/image/20210120/Chromebook-Spin-511-R753T-Bk-modelpreview.png",
                Price= 66000
               },
                 new Acer()
               {
                Id="26",
                Name="Acer Chromebook Spin 512 (R853TA)",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_Spin_512/Images/20210205/Chromebook-Spin-512-R853TA_modelpreview.png",
                Price= 83000
               },
                new Acer()
               {
                Id="27",
                Name="Acer Chromebook Spin 514",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Acer-Chromebook-Enterprise-Spin-514/image/20210106/Chromebook-Spin-514-CP514-1HH-Sv_modelpreview.png",
                Price= 83000
               },
                 new Acer()
               {
                Id="28",
                Name="Acer Chromebook 311",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_311/Images/20190726/Acer-Chromebook-311-CB311-9H-9HT-preview.png",
                Price= 29000
               },
                 new Acer()
               {
                Id="29",
                Name="Acer Chromebook Spin 311",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_Spin_311/Images/20190417/Acer-Chromebook-Spin-311-R721T-preview.png",
                Price= 35000
               },
                 new Acer()
               {
                Id="30",
                Name="Acer Chromebook Spin 513",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Acer_Chromebook_Spin_513/Images/20201013/Acer-Chromebook-Spin-513_CP513-1H-1HL_modelpreview.png",
                Price= 58000
               },
                 new Acer()
               {
                Id="31",
                Name="Acer Chromebook 314",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_314/Images/20190723/Acer-Chromebook-314-CB314-1H-1HT-preview.png",
                Price= 41000
               },
                 new Acer()
               {
                Id="32",
                Name="Acer Chromebook 314 (C933/C933T)",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/acer-chromebook-314/images/20200518/Acer-Chromebook-314-C933-Black-modelpreview.png",
                Price= 42000
               },
                 new Acer()
               {
                Id="33",
                Name="Acer Chromebook 315",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_315/Images/20190726/Acer-Chromebook-315-CB315-3H-3HT-preview.png",
                Price= 45000
               },
                 new Acer()
               {
                Id="34",
                Name="Acer Chromebook Spin 511",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_Spin_511/Images/20190417/Acer-Chromebook-Spin-511-R752TN-preview.png",
                Price= 55000
               },
                new Acer()
               {
                Id="35",
                Name="Acer Chromebook 512",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_512/Images/20190423/Acer-Chromebook-512-C851-C851T-preview.png",
                Price= 56000
               },
                 new Acer()
               {
                Id="36",
                Name="Acer Chromebook Spin 512",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_314/Images/20190723/Acer-Chromebook-314-CB314-1H-1HT-preview.png",
                Price= 55000
               },
                 new Acer()
               {
                Id="37",
                Name="Acer Chromebook 712",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Acer-Chromebook-Spin-712/imges/20200407/Acer-Chromebook-712_C871-C871T_modelpreview.png",
                Price= 77000
               },
                 new Acer()
               {
                Id="38",
                Name="Acer Chromebook Spin 713",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Acer-Chromebook-Spin-713/Images/20200508/Acer-Chromebook-Spin-713_CP713-2W_modelpreview.png",
                Price= 75000
               },
               new Acer()
               {
                Id="39",
                Name="Acer Chromebook 714",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_714/Images/20190423/Acer-Chromebook-714-CB714-1W-CB714-1WT-preview.png",
                Price= 80000
               },
                 new Acer()
               {
                Id="40",
                Name="Acer Chromebook 715",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_715/Images/20190418/Acer-Chromebook-715-CB715-1W-CB715-1WT-preivew.png",
                Price= 125000
               },
                 new Acer()
               {
                Id="41",
                Name="Acer Chromebook Tab 10",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_Tab_10/Images/20180328/Acer-Chromebook-Tab-10-D651N-preview.png",
                Price= 20000
               },
                 new Acer()
               {
                Id="42",
                Name="Acer Chromebook Enterprise Spin 713",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Acer-Chromebook-Enterprise-Spin-713_/20200624/Acer-Chromebook-Enterprise-SPIN-713_preview.png",
                Price= 88000
               },
                new Acer()
               {
                Id="43",
                Name="Acer Chromebook Enterprise 715",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_715/Images/20190418/Acer-Chromebook-715-CB715-1W-CB715-1WT-preivew.png",
                Price= 110000
               },
                 new Acer()
               {
                Id="44",
                Name="Acer Chromebook 13 CB713",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook-13-CB713/images/20181023/Acer-Chromebook-13-CB713-1W-preview.png",
                Price= 29000
               },
                 new Acer()
               {
                Id="45",
                Name="Acer Chromebook Spin 15 CP315",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_Spin_15_CP315/Images/20180412/Acer-Chromebook-Spin-15-CP315-1H-preview.png",
                Price= 33000
               },
                 new Acer()
               {
                Id="46",
                Name="Acer Chromebook 15 CB315",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_Spin_15_CB315/images/20180517/Acer-Chromebook-15-CB315-1H-CB315-1HT-preview.png",
                Price= 36000
               },
                 new Acer()
               {
                Id="47",
                Name="Acer Chromebook 11 CB311",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_11_CB311/Image/20180223/Chromebook-11-CB311-8H_CB311-8HTpreview.png",
                Price= 25000
               },
                 new Acer()
               {
                Id="48",
                Name="Acer Chromebook Spin 11 CP311",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_Spin_11_CP311/Images/20180412/Acer-Chromebook-Spin-11-CP311-preview.png",
                Price= 31000
               },
                 new Acer()
               {
                Id="49",
                Name="Acer Chromebook 11 CB3-132",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_11/Images/20180221/AcerChromebook11_CB3-132_white_preview.png",
                Price= 29000
               },
                 new Acer()
               {
                Id="50",
                Name="Acer Chromebook 15",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_15/Images/20170811/Chromebook-15_preview.png",
                Price= 55000
               },
                new Acer()
               {
                Id="51",
                Name="Acer Chromebook R 13",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_R13/Images/20160824/Chromebook-R-13_preview.png",
                Price= 65000
               },
                 new Acer()
               {
                Id="52",
                Name="Acer Chromebook 11",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_11/Images/20170802/Acer-Chromebook-11_preview.png",
                Price= 55000
               },
                 new Acer()
               {
                Id="53",
                Name="Acer Chromebook Spin 11",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_Spin_11/Image/20170502/Chromebook-Spin-11_black_preview.png",
                Price= 59000
               },
                 new Acer()
               {
                Id="54",
                Name="Acer Chromebook 14",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_14/Images/20160223/Chromebook_14-sku-preview.png",
                Price= 78000
               },
                new Acer()
               {
                Id="55",
                Name="Acer Chromebook R 11",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_11/Images/20181019/Ac_CB5-132T_C738T_white-preview.png",
                Price= 55000
               },
                 new Acer()
               {
                Id="56",
                Name="Acer Chromebook 11 N7",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_11_N7/Image/20170105/Chromebook%2011%20N7_preview.png",
               },
                 new Acer()
               {
                Id="57",
                Name="Acer Chromebook 514",
                Photo="https://static.acer.com/up/Resource/Acer/Laptops/Chromebook_514/Image/20180921/Acer-Chromebook-514-CB514-1H-preview.png",
                Price= 78000
               },



                 //Dell


                 //3000
                   new Acer()
               {
                Id="58",
                Name="Inspiron 15 3505",
                Photo="http://godgetreview.com/wp-content/uploads/2021/01/dell-inspiron-15-3505-specs-and-details_godgetreview.com_-600x380.jpg",
                Price= 100000
               },
                new Acer()
               {
                Id="59",
                Name="Inspiron 15 3501",
                Photo="https://images-na.ssl-images-amazon.com/images/I/81Q8ANgDYAL._SL1500_.jpg",
                Price= 94000
               },
                 new Acer()
               {
                Id="60",
                Name="Inspiron 15 3593",
                Photo="https://static.toiimg.com/photo/76636230/Dell-Inspiron-15-3593-D560159WIN9S-Laptop-Core-i3-10th-Gen8-GB1-TBWindows-10.jpg",
                Price=66000
               },
                 new Acer()
               {
                Id="61",
                Name="Dell Vostro 3401",
                Photo="https://itti.com.np/pub/media/catalog/product/cache/d73a5018306142840707bd616a4ef293/d/e/dell-vostro-3401-i3-10th-generation-5.jpg",
                Price= 59000
               },
                 new Acer()
               {
                Id="62",
                Name="DELL Inspiron 15 3000",
                Photo="https://rukminim1.flixcart.com/image/416/416/jms25jk0/computer/h/z/y/dell-na-laptop-original-imaf9hu7hhf8s8ys.jpeg?q=70",
                Price= 46000
               },


                 //5000
                 new Acer()
               {
                Id="63",
                Name="Inspiron 14 5400",
                Photo="https://i1.wp.com/laptopmedia.com/wp-content/uploads/2020/08/1-8.jpg?fit=1500%2C1016&ssl=1",
                Price= 121000
               },
                 new Acer()
               {
                Id="64",
                Name="Inspiron 15 5593",
                Photo="https://cdn1.smartprix.com/rx-inoeDkRbi-w1200-h1200/dell-inspiron-15-559.jpg",
                Price= 105000
               },
                 new Acer()
               {
                Id="65",
                Name="Inspiron 13 5391",
                Photo="https://i2.wp.com/laptopmedia.com/wp-content/uploads/2020/01/1-6-e1577964645143.jpg?fit=1044%2C690&ssl=1",
                Price= 103000
               },
                 new Acer()
               {
                Id="66",
                Name="Inspiron 15 5502",
                Photo="https://sonuptraders.com/wp-content/uploads/2021/02/71WJc4NrDyL._SL1500_.jpg",
                Price= 80000
               },
                 new Acer()
               {
                Id="67",
                Name="Inspiron 15 5405",
                Photo="https://i.dell.com/is/image/DellContent//content/dam/global-site-design/product_images/dell_client_products/notebooks/inspiron_notebooks/14_5405/pdp/notebooks-inspiron-14-5405-amd-laptop-pdp-design-gallery504x350.jpg?fmt=jpg&wid=570&hei=400",
                Price= 81000
               },
                 new Acer()
               {
                Id="68",
                Name="Inspiron 14 5402",
                Photo="https://i.dell.com/is/image/DellContent//content/dam/global-site-design/product_images/dell_client_products/notebooks/inspiron_notebooks/14_5401_5408/pdp/notebooks-inspiron-14-5401-5408-laptop-pdp-design-gallery504x350_silver.jpg?fmt=jpg&wid=570&hei=400",
                Price= 78000
               },
                new Acer()
               {
                Id="69",
                Name="Inspiron 14 5406",
                Photo="https://i.dell.com/is/image/DellContent//content/dam/global-asset-library/Products/Notebooks/Inspiron/14_5406_2n1/in5406t_ctb_00030lf120_gy.psd?fmt=pjpg&pscan=auto&scl=1&wid=3674&hei=2664&qlt=85,0&resMode=sharp2&op_usm=1.75,0.3,2,0&size=3674,2664",
                Price= 105000
               },
                 new Acer()
               {
                Id="70",
                Name="Inspiron 14 5301",
                Photo="https://static-01.daraz.com.np/p/9f6428f4ef7508de91d6eb6e3b2beaa8.jpg",
                Price=11000
               },

                 //7000
                 new Acer()
               {
                Id="71",
                Name="Inspiron 14 7490",
                Photo="https://i.gadgets360cdn.com/products/large/inspiron147007490-db-1146x800-1569332980.jpg",
                Price= 118000
               },
                 new Acer()
               {
                Id="72",
                Name="Inspiron 13 7391",
                Photo="https://www.notebookcheck.net/uploads/tx_nbc2/DellInspiron13-7391__3_.JPG",
                Price= 115000
               },
                 new Acer()
               {
                Id="73",
                Name="Inspiron 13 7300",
                Photo="https://i.dell.com/is/image/DellContent//content/dam/global-site-design/product_images/dell_client_products/notebooks/inspiron_notebooks/13_7300/pdp/laptops_inspiron_13_7300_pdp_gallery-504x350-silver.png?fmt=jpg&wid=570&hei=400",
                Price= 119000
               },
                 new Acer()
               {
                Id="74",
                Name="Inspiron 13 7306",
                Photo="https://www.notebookcheck.net/uploads/tx_nbc2/DellInspiron13-7306-2in1__1_.jpg",
                Price= 120000
               },
                 new Acer()
               {
                Id="75",
                Name="Inspiron 14 7400",
                Photo="https://www.notebookcheck.net/fileadmin/Notebooks/Dell/Inspiron_14_7400-VY8JW/Dell_Inspiron_14_7400_4.jpg",
                Price= 123000
               },
                 new Acer()
               {
                Id="76",
                Name="Inspiron 15 7501",
                Photo="https://cdn.stopgrab.com/product/gadgets-care/2020/dec/Lj3xOWSZjVixIdycu5bp5OOsX0vPtjxMyhHhzcuB.jpeg",
                Price= 180000
               },


                 //G series

                 new Acer()
               {
                Id="77",
                Name="G3 15 G3500",
                Photo="https://images-na.ssl-images-amazon.com/images/I/81mCXWHK-nL._AC_SL1500_.jpg",
                Price= 73990
               },
                 new Acer()
               {
                Id="78",
                Name="Dell G3 15 3590 2020",
                Photo="https://images-na.ssl-images-amazon.com/images/I/71BJZQrY65L._AC_SY355_.jpg",
                Price= 120800
               },
                new Acer()
               {
                Id="79",
                Name="G3 15 3500",
                Photo="https://www.notebookcheck.net/fileadmin/Notebooks/Dell/G3_15_3500-G4DG2/Dell_G3_15_2_0.jpg",
                Price= 117705
               },
                 new Acer()
               {
                Id="80",
                Name="G7 15 7500",
                Photo="https://static.hub.91mobiles.com/wp-content/uploads/2020/09/Dell-G7-15-7500.png",
                Price=237500
               },
                 new Acer()
               {
                Id="81",
                Name="G5 15 5500",
                Photo="https://brain-images-ssl.cdn.dixons.com/3/6/10209363/u_10209363.jpg",
                Price= 242250
               },


                 //Alienware
               //  new Acer()
               //{
               // Id="82",
               // Name="Dell Alienware M15 R3",
               // Photo="https://itti.com.np/pub/media/catalog/product/cache/c687aa7517cf01e65c009f6943c2b1e9/d/e/dell-alienware-m15-r3-gaming-laptop-price-nepal.jpg",
               // Price= 310000
               //},
                 new Acer()
               {
                Id="82",
                Name="Alienware 17",
                Photo="https://i.pcmag.com/imagery/reviews/05NFRGrJcf8iz4j4nbdeu9G-4..1569474147.jpg",
                Price= 304000
               },
                 new Acer()
               {
                Id="83",
                Name="Alienware Area-51m R2",
                Photo="https://i.dell.com/is/image/DellContent//content/dam/global-site-design/product_images/dell_client_products/notebooks/alienware_notebooks/17_area-51m_non-tobii/pdp/laptops-aw-alienware-area-51m-r2-nt-pdp-mod-hero.jpg?fmt=jpg&wid=570&hei=400",
                Price= 230100
               },
                 new Acer()
               {
                Id="84",
                Name="ALIENWARE m17 R3",
                Photo="https://i.dell.com/is/image/DellContent//content/dam/global-asset-library/Products/Notebooks/Alienware/m17_r3_non-touch_non-tobii/awm17_r3_cnb_05000ff090_wh.psd?fmt=pjpg&pscan=auto&scl=1&wid=3746&hei=2718&qlt=85,0&resMode=sharp2&op_usm=1.75,0.3,2,0&size=3746,2718",
                Price=  330000
               },
                 new Acer()
               {
                Id="85",
                Name="Alienware m17 R1",
                Photo="https://www.notebookcheck.net/fileadmin/Notebooks/News/_nc3/Alienware_m17_left_angle_open_exterior_dark.png",
                Price= 470000
               },
                 new Acer()
               {
                Id="86",
                Name="Dell Alienware M14X",
                Photo="https://www.gadgetsnow.com/photo/54239081/Dell-Alienware-M14X-Laptop.jpg",
                Price= 255800
               },


                 //Xps
                new Acer()
               {
                Id="87",
                Name="XPS 13 7390",
                Photo="https://meroepasal.com/wp-content/uploads/2020/10/xpa1.jpg",
                Price= 200000
               },
                new Acer()
               {
                Id="88",
                Name="XPS 15 9500",
                Photo="https://specials-images.forbesimg.com/imageserve/5f41db3cf98977d701da5675/960x0.jpg?fit=scale",
                Price= 174800
               },
                 new Acer()
               {
                Id="89",
                Name="XPS 13 9300",
                Photo="https://cdn.stopgrab.com/product/gadgets-care/2020/dec/8uHN0PwGGyed20PfhomsvMdKkMOdpLFAjFaaZ2vn.jpeg",
                Price=155000
               },
                 new Acer()
               {
                Id="90",
                Name="The Dell XPS 17",
                Photo="https://specials-images.forbesimg.com/imageserve/5f4427f59ecf5167fdaf0ea0/960x0.jpg?fit=scale",
                Price= 223000
               },
                 new Acer()
               {
                Id="91",
                Name="Dell XPS 13 9310",
                Photo="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQqBfPchLBHQtPzeAmmXRMVTiqh4a46WYCCrg&usqp=CAU",
                Price= 308850
               },
                 new Acer()
               {
                Id="92",
                Name="Dell XPS 15 7590",
                Photo="https://images.anandtech.com/doci/14506/XPS-15_left-angle-open.jpg",
                Price=  230800
               },
                 new Acer()
               {
                Id="93",
                Name="Dell XPS 15 9570",
                Photo="https://itti.com.np/pub/media/catalog/product/cache/c687aa7517cf01e65c009f6943c2b1e9/d/e/dell-alienware-m15-r3-gaming-laptop-price-nepal.jpg",
                Price= 196800
               },
                 new Acer()
               {
                Id="94",
                Name="Dell xps 15 9560 3D",
                Photo="https://static.turbosquid.com/Preview/001243/188/NX/dell-xps-15-9560-3D_600.jpg",
                Price= 295000
               },
                 new Acer()
               {
                Id="95",
                Name="Dell XPS 13 9370",
                Photo="https://images-na.ssl-images-amazon.com/images/I/41D1SYZ2sPL.jpg",
                Price= 140000
               },



                 //Asus

                 //Vivobook
                 new Acer()
               {
                Id="96",
                Name="VivoBook 14 T401MA",
                Photo="https://i2.wp.com/laptopmedia.com/wp-content/uploads/2017/08/ASUS-VivoBook-Flip-14-TP401.jpg?fit=1200%2C869&ssl=1",
                Price= 57700
               },

                 new Acer()
               {
                Id="97",
                Name="VivoBook X409JA",
                Photo="https://images-na.ssl-images-amazon.com/images/I/61z7MFZZAvL._SL1500_.jpg",
                Price= 76000
               },
                new Acer()
               {
                Id="98",
                Name="VivoBook K403FA",
                Photo="https://dam.which.co.uk/e94cc0ce-6a5a-456a-839a-83ce2fc77711.jpg",
                Price= 131000
               },
                 new Acer()
               {
                Id="99",
                Name="VivoBook Flip 14",
                Photo="https://i2.wp.com/laptopmedia.com/wp-content/uploads/2017/08/ASUS-VivoBook-Flip-14-TP401.jpg?fit=1200%2C869&ssl=1",
                Price=81000
               },
                 new Acer()
               {
                Id="100",
                Name="VivoBook X412FA",
                Photo="https://dam.which.co.uk/e94cc0ce-6a5a-456a-839a-83ce2fc77711.jpg",
                Price= 88000
               },
                 new Acer()
               {
                Id="101",
                Name="VivoBook X509JP",
                Photo="https://images-na.ssl-images-amazon.com/images/I/71NSlf4DcVL._SL1500_.jpg",
                Price= 90400
               },
                 new Acer()
               {
                Id="102",
                Name="VivoBook K513EQ",
                Photo="https://itti.com.np/pub/media/catalog/product/cache/c687aa7517cf01e65c009f6943c2b1e9/g/i/gi0fajmircfbjpnd_setting_fff_1_90_end_500.png_1.jpeg",
                Price= 149000
               },
                 new Acer()
               {
                Id="103",
                Name="VivoBook K403FA",
                Photo="https://i2.wp.com/laptopmedia.com/wp-content/uploads/2017/08/ASUS-VivoBook-Flip-14-TP401.jpg?fit=1200%2C869&ssl=1",
                Price= 106000
               },


                 //Zenbook
                 new Acer()
               {
                Id="104",
                Name="ZenBook 14 UM462DS",
                Photo="https://img.etimg.com/photo/msid-74006063,quality-100/the-flip-14-is-powered-by-a-ryzen-5-3500u-processor-that-comes-with-radeon-vega-8-integrated-graphics-processing-unit-gpu-.jpg",
                Price= 92000
               },
                 new Acer()
               {
                Id="105",
                Name="ZenBook 13 UX325JA",
                Photo="https://i2.wp.com/laptopmedia.com/wp-content/uploads/2017/08/ASUS-VivoBook-Flip-14-TP401.jpg?fit=1200%2C869&ssl=1",
                Price= 125000
               },
                 new Acer()
               {
                Id="106",
                Name="ZenBook 14 UX425JA",
                Photo="https://img.etimg.com/photo/msid-74006063,quality-100/the-flip-14-is-powered-by-a-ryzen-5-3500u-processor-that-comes-with-radeon-vega-8-integrated-graphics-processing-unit-gpu-.jpg",
                Price= 120000
               },
                new Acer()
               {
                Id="107",
                Name="ZenBook Flip 13 UX363FA",
                Photo="https://nagmani.com.np/pub/media/catalog/product/cache/a1260b336c43add486894ccab65420c0/1/_/1_22_3.png",
                Price=  146000
               },
                new Acer()
               {
                Id="108",
                Name="ZenBook 13 UFX325EA",
                Photo="https://www.notebookcheck.net/uploads/tx_nbc2/2373115-n0.jpg",
                Price= 154000
               },
                 new Acer()
               {
                Id="109",
                Name="ZenBook 14 UX434FL",
                Photo="https://www.zdnet.com/a/hub/i/r/2019/08/15/f2670f09-356a-4dd6-9f62-925090b22371/resize/1200x900/5225eba338d65d986c7b61dcc03df4aa/asus-zenbook-14-header.jpg",
                Price=120000
               },
                 new Acer()
               {
                Id="110",
                Name="ZenBook 14 UX434FQ",
                Photo="https://nagmani.com.np/pub/media/catalog/product/cache/a1260b336c43add486894ccab65420c0/1/_/1_22_3.png",
                Price= 142000
               },
                 new Acer()
               {
                Id="111",
                Name="ZenBook Flip UX363EA",
                Photo="https://www.notebookcheck.net/uploads/tx_nbc2/2373115-n0.jpg",
                Price= 146000
               },
                 new Acer()
               {
                Id="112",
                Name="ZenBook 14 UX425JA",
                Photo="https://i2.wp.com/laptopmedia.com/wp-content/uploads/2017/08/ASUS-VivoBook-Flip-14-TP401.jpg?fit=1200%2C869&ssl=1",
                Price= 127777
               },
                 new Acer()
               {
                Id="113",
                Name="ZenBook 13 UX325JA",
                Photo="https://www.zdnet.com/a/hub/i/r/2019/08/15/f2670f09-356a-4dd6-9f62-925090b22371/resize/1200x900/5225eba338d65d986c7b61dcc03df4aa/asus-zenbook-14-header.jpg",
                Price= 125000
               },
                 new Acer()
               {
                Id="114",
                Name="ZenBook 14 UFX435EG",
                Photo="https://www.gadgetbytenepal.com/wp-content/uploads/2020/04/ASUS-TUF-Gaming-series.jpg",
                Price= 153000
               },
               //  new Acer()
               //{
               // Id="115",
               // Name="ZenBook 13 UFX325EA",
               // Photo="https://www.notebookcheck.net/uploads/tx_nbc2/AsusZenBook13-UX325EA__1_.JPG",
               // Price= 154000
               //},
                 new Acer()
               {
                Id="115",
                Name="ZenBook Flip 13 UX363FA",
                Photo="https://itti.com.np/pub/media/catalog/product/cache/c687aa7517cf01e65c009f6943c2b1e9/a/s/asus-zenbook-flip-13-ux363fa-price-specs-review-nepal_1.jpg",
                Price= 146000
               },
                  new Acer()
               {
                Id="116",
                Name="ZenBook Flip UX363EA",
                Photo="https://itti.com.np/pub/media/catalog/product/cache/c687aa7517cf01e65c009f6943c2b1e9/a/s/asus-zenbook-flip-13-ux363fa-price-specs-review-nepal_2.jpg",
                Price= 146000
               },
                new Acer()
               {
                Id="117",
                Name="ZenBook 15 UX534FTC",
                Photo="https://irmitek.com/wp-content/uploads/2021/01/Asus-ZenBook-15-UX534FTC-A8116T-Intel-Core-i7-10510U.jpg",
                Price= 200000
               },
                 new Acer()
               {
                Id="118",
                Name="ZenBook Duo UX481",
                Photo="https://assets.mspimages.in/wp-content/uploads/2019/10/ASUS-ZenBook-Duo-UX481FL-14.jpg",
                Price=228000
               },



                 //TUF
                 new Acer()
               {
                Id="119",
                Name="TUF F15 Gaming",
                Photo="https://www.zdnet.com/a/hub/i/r/2019/08/15/f2670f09-356a-4dd6-9f62-925090b22371/resize/1200x900/5225eba338d65d986c7b61dcc03df4aa/asus-zenbook-14-header.jpg",
                Price= 132000
               },
                 new Acer()
               {
                Id="120",
                Name="TUF A15 FA506IU",
                Photo="https://c1.neweggimages.com/ProductImage/34-235-505-V13.jpg",
                Price= 161000
               },


                 //Zephyrus
                 new Acer()
               {
                Id="121",
                Name="ROG Strix G15 G512LI",
                Photo="https://itti.com.np/pub/media/catalog/product/cache/c687aa7517cf01e65c009f6943c2b1e9/g/5/g5122_1_.jpg",
                Price= 143000
               },
                 new Acer()
               {
                Id="122",
                Name="ROG Strix G15 G512LU",
                Photo="https://images-eu.ssl-images-amazon.com/images/I/51m7wzXiuVL._AC_UL474_SR474,450_.jpg",
                Price= 186000
               },
                 new Acer()
               {
                Id="123",
                Name="ROG Strix Scar 15 G532LV",
                Photo="https://www.notebookcheck-cn.com/uploads/tx_nbc2/ASUSZephyrusG14-GA401IU__1_.jpg",
                Price= 410000
               },
                 new Acer()
               {
                Id="124",
                Name="Zephyrus G14 GA401IU",
                Photo="https://www.notebookcheck.net/uploads/tx_nbc2/G14-White-53_09.jpg",
                Price= 200000
               },
                 new Acer()
               {
                Id="125",
                Name="Zephyrus G14 GA401IV",
                Photo="https://www.notebookcheck-cn.com/uploads/tx_nbc2/ASUSZephyrusG14-GA401IU__1_.jpg",
                Price= 220000
               },


                 //lenevo


                 //V series

                 new Acer()
               {
                Id="126",
                Name="Lenovo V15",
                Photo="https://www.lenovo.com/medias/ww-lenovo-laptop-v15-series-400x300.png?context=bWFzdGVyfHJvb3R8MjA4MTB8aW1hZ2UvcG5nfGg3Yi9oMjgvMTA2MDIyNTAyMDcyNjIucG5nfGYzMTQzOGNjOGJhNDViMDgzNDJkZTYxZDBiNDQxNzc5NmJhN2E0ZWQ3OTI1Y2U5OTgwZDJmMDk5YWJjYzdlYzc",
                Price= 83040
               },
                new Acer()
               {
                Id="127",
                Name="Lenevo V130",
                Photo="http://shop.thinkiqbs.com/wp-content/uploads/2019/09/lenovo-laptop-v-series-hero-2.png",
                Price=  28855
               },
                 new Acer()
               {
                Id="128",
                Name="Lenevo V17",
                Photo="https://www.lenovo.com/medias/lenovo-laptops-v-series-v17i-front.png?context=bWFzdGVyfHJvb3R8MjEwMzl8aW1hZ2UvcG5nfGg5YS9oNzcvMTA5NDY1ODUxNjU4NTQucG5nfDljNTE4YTk0MjE5OTExMGQzZTMzN2QwYWEyN2EwM2Y4OWFhNzU5YmMyMTMxY2EwNTY2ZGU2MjBjZmIwM2E3NDE",
                Price=125000
               },
                 new Acer()
               {
                Id="129",
                Name="Lenevo V510",
                Photo="https://www.lenovo.com/medias/lenovo-laptop-v510-14-hero.png?context=bWFzdGVyfHJvb3R8NjQyNTN8aW1hZ2UvcG5nfGgxYS9oZGQvOTQ1Mjg2MTkxNTE2Ni5wbmd8YmMwYWQ0NDRkM2UwNTM1NDNlZThmYjY5YjM5ZDNkZGMzZDc2NmQxNDgzZWE0YTBmOWY4YmQwODg5NDQ3Yjg2ZA",
                Price= 110000
               },
                 new Acer()
               {
                Id="130",
                Name="Lenovo V 310",
                Photo="https://rukminim1.flixcart.com/image/416/416/jc6jl3k0/computer/9/h/b/lenovo-v-310-laptop-original-imaff6uzubzgz7tt.jpeg?q=70",
                Price= 48000
               },
                 new Acer()
               {
                Id="131",
                Name="Lenevo V14",
                Photo="https://www.laptoparena.net/images/Lenovo_V_V14_81YB002KSP_image_1.jpg",
                Price= 62500
               },


                 //Ideapad

                 new Acer()
               {
                Id="132",
                Name="Ideapad S145",
                Photo="https://images-na.ssl-images-amazon.com/images/I/81z5-EY9T3L._SL1500_.jpg",
                Price= 59000
               },
                 new Acer()
               {
                Id="133",
                Name="Ideapad Duet 3i",
                Photo="https://www.lenovo.com/medias/lenovo-laptop-ideapad-duet-3-10-subseries-hero.png?context=bWFzdGVyfHJvb3R8NTU2ODl8aW1hZ2UvcG5nfGgxYy9oYWUvMTA5MjU4MTQ2NDQ3NjYucG5nfDlhZTM1NDczNjAxNzY1ZmEzNTUzMTU2OTQ4NTJhM2QxZWZlNDJlMjQ4NmE2OWY4NzE0OTZjNzY0ZWYzNzc3NGY&w=480",
                Price= 50000
               },
                 new Acer()
               {
                Id="134",
                Name="Ideapad Flex 5",
                Photo="https://brain-images-ssl.cdn.dixons.com/7/2/10208027/u_10208027.jpg",
                Price= 85000
               },
                 new Acer()
               {
                Id="135",
                Name="Ideapad Slim 3i",
                Photo="https://www.lenovo.com/medias/Ideapad-Slim-3i-15-.png?context=bWFzdGVyfHJvb3R8ODI2NzF8aW1hZ2UvcG5nfGhiNi9oMGEvMTExMjYyNjAyNjkwODYucG5nfDdmYjAwYzIzZTI3ZWEwMjI1NzRlYTkwOWYyMTE3Y2UzODlmNmFmZmU5YThhZTBjNWY0YmYzZjE1YzRjNTVlYTc",
                Price= 68800
               },
                new Acer()
               {
                Id="136",
                Name="Ideapad 5 14",
                Photo="https://www.lenovo.com/medias/lenovo-laptops-ideapad-5-14-amd-gallery-1.jpg?context=bWFzdGVyfHJvb3R8MjU2ODIwfGltYWdlL2pwZ3xoYWUvaGE1LzEwNzUwNTE1ODA2MjM4LmpwZ3xjN2E0NTM5ZDlkMjY1ZjU5NDg2NzAxMTFhMWU5YzM2YWRkMzZlOThiZWM1ZGNkZDgwZWIxYjM5OTU3Mzg0YWM5",
                Price= 85000
               },



                //IdeaPad_Gaming

                new Acer()
               {
                Id="137",
                Name="Ideapad Gaming 3",
                Photo="ttps://hnsfpau.imgix.net/5/images/detailed/140/82207.01.jpg?fit=fill&bg=0FFF&w=1500&h=844&auto=format,compress",
                Price= 139000
               },
                 new Acer()
               {
                Id="138",
                Name="Ideapad Gaming 3i",
                Photo="https://www.lenovo.com/medias/lenovo-laptop-legion-ideapad-3-gaming-hero.png?context=bWFzdGVyfHJvb3R8Njc3MzN8aW1hZ2UvcG5nfGhlZS9oNWYvMTA4NTEwODU3MTM0MzgucG5nfGM3MzZhMWRhMWMxMDFiOTUwOWE4ZjVmNjY3Nzk0ZWIxMWZkYzhhOGRiMzE5MjUyOWY3NGE0OTNkYWE0YjE1MjQg",
                Price=125000
               },


                 //Flex
                 new Acer()
               {
                Id="139",
                Name="lenevo Flex 14",
                Photo="https://itti.com.np/pub/media/catalog/product/cache/c687aa7517cf01e65c009f6943c2b1e9/f/l/flex_2.jpg",
                Price= 118000
               },

                 //yoga

                 new Acer()
               {
                Id="140",
                Name="Yoga C740",
                Photo="https://cdn.alzashop.com/ImgW.ashx?fd=f3&cd=NT302o3j0nad",
                Price= 77000
               },
                 new Acer()
               {
                Id="141",
                Name="Yoga 7i",
                Photo="https://images-na.ssl-images-amazon.com/images/I/51LLpQi%2BEdL._AC_SX425_.jpg",
                Price= 93920
               },
                 new Acer()
               {
                Id="142",
                Name="Yoga Duet 7i",
                Photo="https://www.lenovo.com/medias/lenovo-laptop-yoga-duet-7-subseries-hero.png?context=bWFzdGVyfHJvb3R8MzM0NjI1fGltYWdlL3BuZ3xoNzAvaDQ5LzEwNzg2MTI5MzQ2NTkwLnBuZ3wyZjUyMGRiMjk2N2JkN2UyNGU4ODg4ZjRhZjY0MzkzNWYwM2E1MjFkMjcwYzc2M2I1ZTg1NjdkZTg4YjE2ZDM2",
                Price= 80000
               },
                 new Acer()
               {
                Id="143",
                Name="Yoga C940",
                Photo="https://www.notebookcheck-cn.com/uploads/tx_nbc2/c94015.jpg",
                Price= 219200
               },


                 //Think book
                 new Acer()
               {
                Id="144",
                Name="ThinkBook 15",
                Photo="https://www.lenovo.com/medias/37-lenovo-thinkbook-15-hero.png?context=bWFzdGVyfHJvb3R8OTM5ODl8aW1hZ2UvcG5nfGg1NC9oNTIvMTA2NzQ5NDE3ODgxOTAucG5nfGM0NDY0YjA2OTE3YmM2ZDljMGZlNDFhZjBiOWFkMTZmZDZjOTkwZjUzNTgyMjIzNDRmMmFiOTk4MjM4YmJhYTI",
                Price= 110000
               },

                 //think pad
                 new Acer()
               {
                Id="145",
                Name="ThinkPad L13 Yoga",
                Photo="https://www.notebookcheck.net/uploads/tx_nbc2/4zu3_yoga_l13.jpg",
                Price= 125000
               },
                 new Acer()
               {
                Id="146",
                Name="ThinkPad T14",
                Photo="https://www.lenovo.com/medias/lenovo-laptop-thinkpad-t14-subseries-hero.png?context=bWFzdGVyfHJvb3R8NjU0Njh8aW1hZ2UvcG5nfGgwNi9oNDkvMTA4MTAzMTkyMDg0NzgucG5nfDk5OGNjMDY1NWNjNDBhZWRjODRmYjRlMWU0YjYzNTVlM2Q4N2Y0YTVkNTc4ZDUxYmEzNDM5N2FhZjMxZmVkOWE",
                Price= 144000
               },
                new Acer()
               {
                Id="147",
                Name="ThinkPad T490",
                Photo="https://www.notebookcheck.net/fileadmin/Notebooks/Lenovo/ThinkPad_T490-20N3S02L00/teaser3.JPG",
                Price= 145000
               },
                 new Acer()
               {
                Id="148",
                Name="ThinkPad X390",
                Photo="https://www.tejar.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/l/e/lenovo_thinkpad_x390_traditional_laptop6_-_tejar.jpg",
                Price=159000
               },
                 new Acer()
               {
                Id="149",
                Name="ThinkPad X1 Carbon",
                Photo="https://itti.com.np/pub/media/catalog/product/cache/c687aa7517cf01e65c009f6943c2b1e9/x/1/x1_carbon_2_1.jpg",
                Price= 198000
               },
                 new Acer()
               {
                Id="150",
                Name="ThinkPad T14S",
                Photo="https://www.lenovo.com/medias/lenovo-laptop-thinkpad-t14s-amd-subseries-gallery-2.jpg?context=bWFzdGVyfHJvb3R8NDA5MTV8aW1hZ2UvanBlZ3xoMDAvaDJjLzEwODU4NTU0NTIzNjc4LmpwZ3wwM2MzZjQ1NGE5ZmZjNjg0YjYzZDJjODZmNzc5ZWZjN2U2Zjk1MmQwYzExOGVhOTM3OTQxN2NkZjcyM2JlZDlj",
                Price= 202000
               },

                 //legion
                 new Acer()
               {
                Id="151",
                Name="Legion 5i",
                Photo="https://www.lenovo.com/medias/lenovo-laptop-legion-5-15-intel-subseries-hero.png?context=bWFzdGVyfHJvb3R8MjM0ODUxfGltYWdlL3BuZ3xoOTgvaGI1LzEwODQ0NjI1NzY0MzgyLnBuZ3xkZGI1ZTNkNDNhZjhkMjNlZDc5ZTQ4OTA1YjMxOTI2MDM1OGFmNDFhN2YyMDdiYWNlNTRmOGY5M2Y4MGU4Y2Ix",
                Price= 71300
               },
                 new Acer()
               {
                Id="152",
                Name="Legion 5",
                Photo="https://www.lenovo.com/medias/lenovo-laptop-legion-5-15-amd-subseries-hero.png?context=bWFzdGVyfHJvb3R8MTY1MTc2fGltYWdlL3BuZ3xoMGEvaGU4LzEwODM3OTM5NjE3ODIyLnBuZ3xiNjNmYTE3M2M2NGY5YjljMmI3ZjhkMmJjYTBmYjkzZDM1MDRhY2QwOTVlODViYTVlZjQyMTljNjE1ODY0ZTNj",
                Price= 220000
               },
                 new Acer()
               {
                Id="153",
                Name="Legion Y540",
                Photo="https://www.lenovo.com/medias/lenovo-legion-y540-15-3.png?context=bWFzdGVyfHJvb3R8MTI1NjA1fGltYWdlL3BuZ3xoYmMvaDY4LzEwMDkyNjE0MjU0NjIyLnBuZ3w5YzU2YTdkYjU3M2UxZjY1NGMyMzlhNDc2ZDAyZjZhNTVhYmFiMTc5NTc1YzZhY2U2N2JlZjU5NzM5OWM2M2Yy",
                Price= 117000
               },
                 new Acer()
               {
                Id="154",
                Name="Lenovo Legion Y530",
                Photo="https://sgp1.digitaloceanspaces.com/awe/itech/items/lenovo_laptop_legion_y530.png",
                Price= 125000
               },
                 new Acer()
               {
                Id="155",
                Name="Lenovo Legion Y520",
                Photo="https://www.notebookcheck.net/uploads/tx_nbc2/LenovoLegionY520-15__1_.jpg",
                Price= 95000
               },




                 //HP

                 //envy

                new Acer()
               {
                Id="156",
                Name="HP ENVY 13",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06565588.png",
                Price= 148000
               },
                new Acer()
               {
                Id="157",
                Name="HP ENVY 14",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06962780.png",
                Price= 166400
               },
                 new Acer()
               {
                Id="158",
                Name="HP ENVY 15",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06586761.png",
                Price=248000
               },
                 new Acer()
               {
                Id="159",
                Name="HP ENVY 17",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06546880.png",
                Price= 264000
               },
                 new Acer()
               {
                Id="160",
                Name="HP ENVY x360",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06564702.png",
                Price= 149000
               },


                 //Spectre
                 new Acer()
               {
                Id="161",
                Name="HP Spectre x360 14",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06924616.png",
                Price= 137375
               },
                 new Acer()
               {
                Id="162",
                Name="HP Spectre x360 15",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06571223.png",
                Price= 225000
               },
                 new Acer()
               {
                Id="163",
                Name="HP Spectre x360 13",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06446004.png",
                Price= 142000
               },
                 new Acer()
               {
                Id="164",
                Name="HP Spectre Folio 13",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06163142.png",
                Price= 77000
               },


                 //Elitebook
                 new Acer()
               {
                Id="165",
                Name="HP Elite Dragonfly",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06453669.png",
                Price= 319072
               },
                 new Acer()
               {
                Id="166",
                Name="HP EliteBook x360 1030",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06615138.png",
                Price= 238400

               },
                new Acer()
               {
                Id="167",
                Name="HP EliteBook x360 1040",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06615220.png",
                Price= 169890

               },
                 new Acer()
               {
                Id="168",
                Name="HP Elite Folio",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c05038439.png",
                Price=238400
               },
                 new Acer()
               {
                Id="169",
                Name="HP EliteBook x360 830",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06615469.png",
                Price= 119172.8

               },
                 new Acer()
               {
                Id="170",
                Name="HP EliteBook 830",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06614463.png",
                Price= 88000
               },
                 new Acer()
               {
                Id="171",
                Name="HP EliteBook 835",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06649517.png",
                Price= 171875

               },
                 new Acer()
               {
                Id="172",
                Name="HP EliteBook 840",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06614696.png",
                Price= 413624

               },
                 new Acer()
               {
                Id="173",
                Name="HP EliteBook 845",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06649744.png",
                Price= 143000
               },


                 //Pavilion

                 new Acer()
               {
                Id="174",
                Name="HP Pavilion 13",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06717444.png",
                Price= 112000

               },
                 new Acer()
               {
                Id="175",
                Name="HP Pavilion x360",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06567409.png",
                Price= 111000
               },
                new Acer()
               {
                Id="176",
                Name="HP Pavilion 14",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06717296.png",
                Price= 88800
               },
                new Acer()
               {
                Id="177",
                Name="HP Pavilion 15",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06901980.png",
                Price= 2.50
               },

                //CHromebook
                 new Acer()
               {
                Id="178",
                Name="HP Chromebook x360",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06595324.png",
                Price=33000
               },
                 new Acer()
               {
                Id="179",
                Name="HP Chromebook Clamshell",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06547859.png",
                Price= 30000
               },

                 //Omen
                 new Acer()
               {
                Id="180",
                Name="OMEN X",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06441692.png",
                Price= 359572.8

               },
                 new Acer()
               {
                Id="181",
                Name="OMEN",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06594960.png",
                Price= 175000
               },


                 //HP laptop
                 new Acer()
               {
                Id="182",
                Name="HP Laptop",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06424852.png",
                Price= 83000
               },
                 new Acer()
               {
                Id="183",
                Name="HP 250",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06199399.png",
                Price= 57600

               },
                 new Acer()
               {
                Id="184",
                Name="HP 255",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06199399.png",
                Price= 66360

               },


                 //Probook 
                 new Acer()
               {
                Id="185",
                Name="HP ProBook 640",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06307172.png",
                Price= 78384

               },
                  new Acer()
               {
                Id="186",
                Name="HP ProBook 650",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06352683.png",
                Price= 176465.6

               },
                new Acer()
               {
                Id="187",
                Name="HP ProBook 430",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06465712.png",
                Price= 111984

               },
                 new Acer()
               {
                Id="188",
                Name="HP ProBook 440",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06197575.png",
                Price=72640

               },
                 new Acer()
               {
                Id="189",
                Name="HP ProBook 450",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06455785.png",
                Price= 145552

               },


                 //
                 new Acer()
               {
                Id="190",
                Name="HP ZBook Fury 17 Mobile Workstation",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06754480.png",
                Price= 492375

               },
                 new Acer()
               {
                Id="191",
                Name="HP ZBook Fury 15 Mobile Workstation",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06753948.png",
                Price= 369875

               },
                 new Acer()
               {
                Id="192",
                Name="HP ZBook Create Notebook PC",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06698717.png",
                Price= 561375

               },
                 new Acer()
               {
                Id="193",
                Name="HP ZBook Studio Mobile Workstation",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06724597.png",
                Price= 362375

               },
                 new Acer()
               {
                Id="194",
                Name="HP ZBook Power 15 Mobile Workstation",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06887069.png",
                Price= 250000

               },

                 //Thin Clients
                 new Acer()
               {
                Id="195",
                Name="HP mt32 Mobile Thin Client",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06986391.png",
                Price= 122250

               },
                new Acer()
               {
                Id="196",
                Name="HP mt22 Mobile Thin Client",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06622124.png",
                Price= 61125

               },
                new Acer()
               {
                Id="197",
                Name="HP mt46 Mobile Thin Client",
                Photo="https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06694844.png",
                Price= 127750

               }


            };

            return Acers;
        }

        public Acer find(string id)
        {
            List<Acer> acers = findAll();
            var prod = acers.Where(a => a.Id == id).FirstOrDefault();
            return prod;
        }

    }


}
