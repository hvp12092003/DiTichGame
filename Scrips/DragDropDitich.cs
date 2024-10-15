using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDiTich
{

    public class DragDropDitich : MonoBehaviour
    {
        private Vector3 posOrin;
        Vector3 offset;

        private void Start()
        {
            posOrin = this.transform.position;
        }

/*
        bool Contains(List<string> viewed, string temp)
        {
            foreach (string t in viewed)
            {
                if (t.Equals(temp))
                {
                    return true;
                }
            }
            return false;
        }*/

        void OnMouseDown()
        {
            offset = transform.position - MouseWorldPosition();
                    }

        void OnMouseDrag()
        {

                transform.position = MouseWorldPosition() + offset;
                               Vector3 pos = transform.position;
                               transform.position = pos;

            

        }
        private void OnMouseUp()
        {
            this.transform.position = posOrin;
        }
        Vector3 MouseWorldPosition()
        {
            var mouseScreenPos = Input.mousePosition;
            mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
            return Camera.main.ScreenToWorldPoint(mouseScreenPos);
        }
    }
}

