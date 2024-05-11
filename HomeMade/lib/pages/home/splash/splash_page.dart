import 'dart:async';
import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:homemade/routes/route_helper.dart';
import 'package:homemade/utils/dimensions.dart';
import '../../../controllers/popular_product_controller.dart';
import '../../../controllers/recommended_product_controller.dart';

class SplashScreen extends StatefulWidget {
  const SplashScreen({Key? key}) : super(key: key);

  @override
  _SplashScreenState createState() => _SplashScreenState();
}

class _SplashScreenState extends State<SplashScreen>
    with TickerProviderStateMixin {
  late Animation<double> animation;
  late AnimationController controller;
  _loadResource() async {
    await Get.find<PopularProductController>().getPopularProductList();
    await Get.find<RecommendedProductController>().getRecommendedProductList();
  }

  @override
  void initState() {
    super.initState();
    _loadResource();
    controller =
        AnimationController(vsync: this, duration: const Duration(seconds: 2))
          ..forward();

    animation = CurvedAnimation(parent: controller, curve: Curves.linear);

    Timer(const Duration(seconds: 3),
        () => Get.offNamed(RouteHelper.getInitial()));
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        backgroundColor: Colors.white,
        body: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            ScaleTransition(
              scale: animation,
              child: Center(
                  child: Image.asset("assets/image/logo.png",
                      width: Dimensions.splashImg)),
            ),
            Center(
                child: Image.asset("assets/image/thebest.png",
                    width: Dimensions.splashImg)),
          ],
        ));
  }
}
