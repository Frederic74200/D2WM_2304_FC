<?php
require 'vendor/autoload.php';

session_start();

if (isset($_POST) && !empty($_POST)) {
    $array = array();

    foreach ($_POST as $key => $value) {

        $array[$key] = $value;
    }
    $_SESSION['array'] = $array;
    require 'src/vue/page.php';
} else {
    require 'src/vue/homepage.php';
}
