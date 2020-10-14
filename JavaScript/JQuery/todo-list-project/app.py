
import sqlite3
from sqlite3 import Error


def create_connection(db_file):
    conn = None
    try:
        conn = sqlite3.connect(db_file)
        return conn

    except Error as e:
        print(e)
    
    return conn


def create_table(conn, create_table_sql):
    try:
        c = conn.cursor()
        c.execute(create_table_sql)

    except Error as e:
        print(e)


def main():
    database = r"D:/Descargas/Programacion/JavaScript/JQuery/todo-list-project/mydatabase.db"

    sql_create_projects_table = """ CREATE TABLE IF NOT EXISTS users (
        id integer PRIMARY KEY AUTOINCREMENT, 
        name varchar(100) NOT NULL, 
        age integer NOT NULL, 
        email varchar(100)  NOT NULL, 
        city varchar(50) NOT NULL
        );
    """

    conn = create_connection(database)

    if conn is not None:
        create_table(conn, sql_create_projects_table)

    else:
        print("Error! Cannot create database connection.")    


if __name__ == '__main__':
    main()







