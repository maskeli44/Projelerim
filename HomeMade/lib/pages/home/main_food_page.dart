import 'package:flutter/material.dart';
import 'package:homemade/pages/home/food_page_body.dart';
import 'package:homemade/utils/colors.dart';
import 'package:homemade/utils/dimensions.dart';
import 'package:homemade/widgets/big_text.dart';
import 'package:homemade/widgets/small_text.dart';

class MainFoodPage extends StatefulWidget {
  const MainFoodPage({Key? key}) : super(key: key);

  @override
  State<MainFoodPage> createState() => _MainFoodPageState();
}

class _MainFoodPageState extends State<MainFoodPage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: Column(
      children: [
        Container(
          child: Container(
              margin: EdgeInsets.only(
                  top: Dimensions.height30, bottom: Dimensions.height15),
              padding: EdgeInsets.only(
                  left: Dimensions.width20, right: Dimensions.width20),
              child: Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Column(
                    children: [
                      BigText(
                        text: "Türkiye",
                        color: AppColors.mainColor,
                      ),
                      Row(
                        children: [
                          SmallText(
                            text: "Şanlıurfa",
                            color: Colors.black54,
                          ),
                          Icon(Icons.arrow_drop_down_rounded)
                        ],
                      )
                    ],
                  ),
                  Center(
                    child: Container(
                      width: Dimensions.width30,
                      height: Dimensions.height30,
                      child: Icon(
                        Icons.search,
                        color: Colors.white,
                        size: Dimensions.iconSize24,
                      ),
                      decoration: BoxDecoration(
                        borderRadius:
                            BorderRadius.circular(Dimensions.radius15),
                        color: AppColors.mainColor,
                      ),
                    ),
                  )
                ],
              )),
        ),
        Expanded(
            child: SingleChildScrollView(
          child: FoodPageBody(),
        ))
      ],
    ));

    /* return Scaffold(
      appBar: AppBar(),
      body: Column(children: [
        Container(
          margin: EdgeInsets.only(top: 45, bottom: 15),
          padding: EdgeInsets.only(
              left: Dimensions.width20, right: Dimensions.width20),
          color: Colors.red,
          child: Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Column(
                children: [
                  BigText(
                      text: "Türkiye", color: AppColors.mainColor, size: 30),
                  SmallText(
                    text: "Şanlıurfa",
                    color: Colors.black54,
                  ),
                  Icon(Icons.arrow_drop_down_rounded),
                ],
              ),
              Center(
                child: Container(
                  width: 45,
                  height: 45,
                  child: Icon(
                    Icons.search,
                    color: Colors.white,
                    size: Dimensions.iconSize24,
                  ),
                  decoration: BoxDecoration(
                    borderRadius: BorderRadius.circular(Dimensions.radius15),
                    color: AppColors.mainColor,
                  ),
                ),
              )
            ],
          ),
        )
      ]),
      body: Column(
        children: [
          //showing the header
          Container(
            child: Container(
              margin: EdgeInsets.only(top: 45, bottom: 15),
              padding: EdgeInsets.only(
                  left: Dimensions.width20, right: Dimensions.width20),
              child: Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Column(
                    children: [
                      BigText(
                          text: "Türkiye",
                          color: AppColors.mainColor,
                          size: 30),
                      SmallText(
                        text: "Şanlıurfa",
                        color: Colors.black54,
                      ),
                      Icon(Icons.arrow_drop_down_rounded),
                    ],
                  ),
                  Center(
                    child: Container(
                      width: 45,
                      height: 45,
                      child: Icon(
                        Icons.search,
                        color: Colors.white,
                        size: Dimensions.iconSize24,
                      ),
                      decoration: BoxDecoration(
                        borderRadius:
                            BorderRadius.circular(Dimensions.radius15),
                        color: AppColors.mainColor,
                      ),
                    ),
                  )
                ],
              ),
            ),
          ),
          //showing the body
          SizedBox(
            height: 200,
            child: SingleChildScrollView(
              child: MainFoodPage(),
            ),
          ),
        ],
      ),*/
  }
}
