<?php

class Connexion
{
    private static $connexion = null;
    private static $host = 'localhost';
    private static $user = "root";
    private static $password = '';
    private static $database = "guide";


    private function __construct()
    {
    }


    public static final function getInstance()
    {
        if (is_null(self::$connexion)) {

            try {
                self::$connexion = new PDO('mysql:host=' . self::$host . ';dbname=' . self::$database, self::$user, self::$password, array(PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_ASSOC, PDO::MYSQL_ATTR_INIT_COMMAND => 'SET NAMES utf8'));
                echo 'ça a marché !';
            } catch (PDOException $e) {
                die('database connexion failled' . $e->getMessage());
                echo "toto";
            }
        }
        return self::$connexion;
    }
}
