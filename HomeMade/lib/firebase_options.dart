// File generated by FlutterFire CLI.
// ignore_for_file: lines_longer_than_80_chars, avoid_classes_with_only_static_members
import 'package:firebase_core/firebase_core.dart' show FirebaseOptions;
import 'package:flutter/foundation.dart'
    show defaultTargetPlatform, kIsWeb, TargetPlatform;

/// Default [FirebaseOptions] for use with your Firebase apps.
///
/// Example:
/// ```dart
/// import 'firebase_options.dart';
/// // ...
/// await Firebase.initializeApp(
///   options: DefaultFirebaseOptions.currentPlatform,
/// );
/// ```
class DefaultFirebaseOptions {
  static FirebaseOptions get currentPlatform {
    if (kIsWeb) {
      throw UnsupportedError(
        'DefaultFirebaseOptions have not been configured for web - '
        'you can reconfigure this by running the FlutterFire CLI again.',
      );
    }
    switch (defaultTargetPlatform) {
      case TargetPlatform.android:
        return android;
      case TargetPlatform.iOS:
        return ios;
      case TargetPlatform.macOS:
        throw UnsupportedError(
          'DefaultFirebaseOptions have not been configured for macos - '
          'you can reconfigure this by running the FlutterFire CLI again.',
        );
      case TargetPlatform.windows:
        throw UnsupportedError(
          'DefaultFirebaseOptions have not been configured for windows - '
          'you can reconfigure this by running the FlutterFire CLI again.',
        );
      case TargetPlatform.linux:
        throw UnsupportedError(
          'DefaultFirebaseOptions have not been configured for linux - '
          'you can reconfigure this by running the FlutterFire CLI again.',
        );
      default:
        throw UnsupportedError(
          'DefaultFirebaseOptions are not supported for this platform.',
        );
    }
  }

  static const FirebaseOptions android = FirebaseOptions(
    apiKey: 'AIzaSyCIg-uXz1tqqiuydOXnBDFy8KekpfygltI',
    appId: '1:950387792751:android:5443300ca920753765e69a',
    messagingSenderId: '950387792751',
    projectId: 'homemade-79d7b',
    databaseURL: 'https://homemade-79d7b-default-rtdb.europe-west1.firebasedatabase.app',
    storageBucket: 'homemade-79d7b.appspot.com',
  );

  static const FirebaseOptions ios = FirebaseOptions(
    apiKey: 'AIzaSyBJnCIBoWbbkKYmvAKZCKcxp21u1bzw5oI',
    appId: '1:950387792751:ios:1b0b21284804125965e69a',
    messagingSenderId: '950387792751',
    projectId: 'homemade-79d7b',
    databaseURL: 'https://homemade-79d7b-default-rtdb.europe-west1.firebasedatabase.app',
    storageBucket: 'homemade-79d7b.appspot.com',
    androidClientId: '950387792751-pujpsqluqmuccokq7k7bft5dc9m19875.apps.googleusercontent.com',
    iosClientId: '950387792751-f1sbl0ng53ge97783if7ti2c8ke8vet5.apps.googleusercontent.com',
    iosBundleId: 'com.example.homemade',
  );
}
