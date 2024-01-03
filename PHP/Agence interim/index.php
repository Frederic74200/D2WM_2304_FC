<?php
session_start();
require 'App/vue/page.php';


$array = array();


if (isset($_POST) && !empty($_POST)) {


    foreach ($_POST as $key => $value) {

        $array[$key] = $value;
    }
}






$_SESSION['array'] = $array;
