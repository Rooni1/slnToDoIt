﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Data
{
    public class TodoSequencer
    {
        //Private Fields
        private static int todoId = 0;
        //Public Props
        public static int TodoId { get { return todoId; } }

        //Increments todoId and returns it, is used to give Todo items unique ids
        public static int NextTodoId()
        {
            return ++todoId;
        }
        //Resets todoId
        public static void ResetTodo()
        {
            todoId = 0;
        }


    }
}
