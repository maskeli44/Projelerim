import 'package:get/get.dart';
import 'package:homemade/controllers/cart_controller.dart';
import 'package:homemade/controllers/recommended_product_controller.dart';
import 'package:homemade/data/repository/cart_repo.dart';
import 'package:homemade/data/repository/popular_product_repo.dart';
import 'package:homemade/data/repository/recommended_product_repo.dart';
import 'package:homemade/utils/app_constants.dart';
import 'package:shared_preferences/shared_preferences.dart';
import '../controllers/popular_product_controller.dart';
import '../data/api/api_client.dart';

Future<void> init() async{
  final sharedPreferences = await SharedPreferences.getInstance();
  Get.lazyPut(()=> sharedPreferences);
  //api client
  Get.lazyPut(()=>ApiClient(appBaseUrl: AppConstants.BASE_URL));
  //repos
  Get.lazyPut(() => PopularProductRepo(apiClient:Get.find()));
  Get.lazyPut(() => CartRepo(sharedPreferences:Get.find()));

  Get.lazyPut(() => RecommendedProductRepo(apiClient:Get.find()));
  //controllers
  Get.lazyPut(() => PopularProductController(popularProductRepo: Get.find()));
  Get.lazyPut(() => RecommendedProductController(recommendedProductRepo: Get.find()));
  Get.lazyPut(() => CartController(cartRepo: Get.find()));
}