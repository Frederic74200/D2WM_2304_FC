<?php
session_start();

if (isset($_POST) && !empty($_POST)) {
    $array = array();

    foreach ($_POST as $key => $value) {

        $array[$key] = $value;
    }
    $_SESSION['array'] = $array;
    require 'App/vue/page.php';
} else {
    require 'App/vue/homePgae.php';
}
