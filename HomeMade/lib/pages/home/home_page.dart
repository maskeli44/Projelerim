import 'dart:io';

import 'package:flutter/material.dart';
import 'package:homemade/pages/cart/cart_history.dart';
import 'package:homemade/pages/home/main_food_page.dart';
import 'package:homemade/utils/colors.dart';
import 'package:image_picker/image_picker.dart';

class HomePage extends StatefulWidget {
  const HomePage({Key? key}) : super(key: key);

  @override
  _HomePageState createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  int _selectedIndex = 0;

  //late PersistentTabController _controller;

  List pages = [
    const MainFoodPage(),
    Container(child: const ImagePick()),
    const CartHistory(),
    Container(child: const Center(child: Text("Next next next Page"))),
  ];

  void onTapNav(int index) {
    setState(() {
      _selectedIndex = index;
    });
  }

  /*
  @override
  void initState(){
    super.initState();
    _controller = PersistentTabController(initialIndex: 0);

  }*/
/*  List<Widget> _buildScreens() {
    return [
      MainFoodPage(),
      Container(child:Center(child:Text("Next Page"))),
      Container(child:Center(child:Text("Next next Page"))),
      Container(child:Center(child:Text("Next next next Page"))),
    ];
  }
  List<PersistentBottomNavBarItem> _navBarsItems() {
    return [
      PersistentBottomNavBarItem(
        icon: Icon(CupertinoIcons.home),
        title: ("Home"),
        activeColorPrimary: CupertinoColors.activeBlue,
        inactiveColorPrimary: CupertinoColors.systemGrey,
      ),
      PersistentBottomNavBarItem(
        icon: Icon(CupertinoIcons.archivebox_fill),
        title: ("Archive"),
        activeColorPrimary: CupertinoColors.activeBlue,
        inactiveColorPrimary: CupertinoColors.systemGrey,
      ),
      PersistentBottomNavBarItem(
        icon: Icon(CupertinoIcons.cart_fill),
        title: ("Cart"),
        activeColorPrimary: CupertinoColors.activeBlue,
        inactiveColorPrimary: CupertinoColors.systemGrey,
      ),
      PersistentBottomNavBarItem(
        icon: Icon(CupertinoIcons.person),
        title: ("Me"),
        activeColorPrimary: CupertinoColors.activeBlue,
        inactiveColorPrimary: CupertinoColors.systemGrey,
      ),
    ];
  }*/
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: pages[_selectedIndex],
      bottomNavigationBar: BottomNavigationBar(
        selectedItemColor: AppColors.mainColor,
        unselectedItemColor: Colors.amberAccent,
        showSelectedLabels: false,
        showUnselectedLabels: false,
        selectedFontSize: 0.0,
        unselectedFontSize: 0.0,
        currentIndex: _selectedIndex,
        onTap: onTapNav,
        items: const [
          BottomNavigationBarItem(
              icon: Icon(
                Icons.home_outlined,
              ),
              label: "home"),
          BottomNavigationBarItem(
              icon: Icon(
                Icons.archive,
              ),
              label: "history"),
          BottomNavigationBarItem(
              icon: Icon(
                Icons.shopping_cart,
              ),
              label: "cart"),
          BottomNavigationBarItem(
              icon: Icon(
                Icons.person,
              ),
              label: "me"),
        ],
      ),
    );
  }

/* @override
  Widget build(BuildContext context) {
  return PersistentTabView(
  context,
  controller: _controller,
  screens: _buildScreens(),
  items: _navBarsItems(),
  confineInSafeArea: true,
  backgroundColor: Colors.white, // Default is Colors.white.
  handleAndroidBackButtonPress: true, // Default is true.
  resizeToAvoidBottomInset: true, // This needs to be true if you want to move up the screen when keyboard appears. Default is true.
  stateManagement: true, // Default is true.
  hideNavigationBarWhenKeyboardShows: true, // Recommended to set 'resizeToAvoidBottomInset' as true while using this argument. Default is true.
  decoration: NavBarDecoration(
  borderRadius: BorderRadius.circular(10.0),
  colorBehindNavBar: Colors.white,
  ),
  popAllScreensOnTapOfSelectedTab: true,
  popActionScreens: PopActionScreensType.all,
  itemAnimationProperties: ItemAnimationProperties( // Navigation Bar's items animation properties.
    duration: Duration(milliseconds: 200),
    curve: Curves.ease,
  ),
  screenTransitionAnimation: ScreenTransitionAnimation( // Screen transition animation on change of selected tab.
    animateTabTransition: true,
    curve: Curves.ease,
   duration: Duration(milliseconds: 200),
  ),
  navBarStyle: NavBarStyle.style1, // Choose the nav bar style with this property.
  );
  }
  }

  */
}

class ImagePick extends StatefulWidget {
  const ImagePick({Key? key}) : super(key: key);

  @override
  State<ImagePick> createState() => _ImagePickState();
}

class _ImagePickState extends State<ImagePick> {
  File? imagePath;

  pickImage() async {
    ImagePicker _picker = ImagePicker();
    // Capture a photo
    final XFile? photo = await _picker.pickImage(source: ImageSource.camera);

    imagePath = File(photo!.path);
    setState(() {});
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Column(
        children: [
          const Text("Pick Image"),
          if (imagePath != null) Image.file(imagePath!),
          TextButton(onPressed: pickImage, child: const Text('pick'))
        ],
      ),
    );
  }
}
