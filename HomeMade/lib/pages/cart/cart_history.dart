import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:homemade/controllers/cart_controller.dart';
import 'package:homemade/utils/app_constants.dart';
import 'package:homemade/utils/colors.dart';
import 'package:homemade/utils/dimensions.dart';
import 'package:homemade/widgets/app_icon.dart';
import 'package:homemade/widgets/big_text.dart';

class CartHistory extends StatelessWidget {
  const CartHistory({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    var getCartHistoryList = Get.find<CartController>().getCartHistoryList();
    Map<String, int> cartItemsPerOrder = Map();

    for (int i = 0; i < getCartHistoryList.length; i++) {
      if (cartItemsPerOrder.containsKey(getCartHistoryList[i].time)) {
        cartItemsPerOrder.update(
            getCartHistoryList[i].time!, (value) => ++value);
      } else {
        cartItemsPerOrder.putIfAbsent(getCartHistoryList[i].time!, () => 1);
      }
    }
    List<int> cartorderTimeToList() {
      return cartItemsPerOrder.entries.map((e) => e.value).toList();
    }

    List<int> itemsPerOrder = cartorderTimeToList();
    var listCounter = 0;
    return Scaffold(
        body: Column(
      children: [
        Container(
          height: 100,
          color: AppColors.mainColor,
          width: double.maxFinite,
          padding: const EdgeInsets.only(top: 45),
          child: Row(
            mainAxisAlignment: MainAxisAlignment.spaceAround,
            children: [
              BigText(text: "Cart History", color: Colors.white),
              AppIcon(
                icon: Icons.add_shopping_cart_outlined,
                iconColor: AppColors.mainColor,
                backgroundColor: AppColors.yellowColor,
              )
            ],
          ),
        ),
        Expanded(
            child: Container(
                margin: EdgeInsets.only(
                  top: Dimensions.height20,
                  left: Dimensions.width20,
                  right: Dimensions.width20,
                ),
                child: MediaQuery.removePadding(
                  removeTop: true,
                  context: context,
                  child: ListView(
                    children: [
                      for (int i = 0; i < itemsPerOrder.length; i++)
                        Container(
                          height: 100,
                          margin: EdgeInsets.only(bottom: Dimensions.height20),
                          child: Column(
                              crossAxisAlignment: CrossAxisAlignment.start,
                              children: [
                                BigText(text: "05/02/2022"),
                                SizedBox(
                                  height: Dimensions.height10,
                                ),
                                Row(
                                  children: [
                                    Wrap(
                                      direction: Axis.horizontal,
                                      children: List.generate(itemsPerOrder[i],
                                          (index) {
                                        if (listCounter <
                                            getCartHistoryList.length) {
                                          listCounter++;
                                        }
                                        return index <= 2
                                            ? Container(
                                                height: 80,
                                                width: 80,
                                                margin: EdgeInsets.only(
                                                    right:
                                                        Dimensions.width10 / 2),
                                                decoration: BoxDecoration(
                                                    borderRadius:
                                                        BorderRadius.circular(
                                                            Dimensions
                                                                    .radius15 /
                                                                2),
                                                    image: DecorationImage(
                                                        fit: BoxFit.cover,
                                                        image: NetworkImage(
                                                            AppConstants
                                                                    .BASE_URL +
                                                                AppConstants
                                                                    .UPLOAD_URL +
                                                                getCartHistoryList[
                                                                        listCounter -
                                                                            1]
                                                                    .img!))),
                                              )
                                            : Container();
                                      }),
                                    )
                                  ],
                                )
                              ]),
                        )
                    ],
                  ),
                )))
      ],
    ));
  }
}
