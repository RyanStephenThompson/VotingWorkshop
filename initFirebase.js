// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Import the functions you need from the SDKs you need
import { initializeApp } from "firebase/app";
import { getFirestore, collection, getDocs } from "firebase/firestore";
import { getAnalytics } from "firebase/analytics";
// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
    apiKey: "AIzaSyAL1KtsUSqvUU2QSQX4Mqqa3LrTB9oHVf8",
    authDomain: "votingfirestore.firebaseapp.com",
    projectId: "votingfirestore",
    storageBucket: "votingfirestore.appspot.com",
    messagingSenderId: "809956925807",
    appId: "1:809956925807:web:0680964223ac2d54d9889a",
    measurementId: "G-L83XY3KDHK"
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);
const analytics = getAnalytics(app);
const db = getFirestore(app);