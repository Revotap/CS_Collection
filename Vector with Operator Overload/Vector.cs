/*
    Author: Leon Grell    
*/

namespace Vector_with_Operator_Overload
{
    class Vector
    {
        private float x;
        private float y;
        private float z;

        /*Constructors*/
        public Vector()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Vector(float n_x, float n_y, float n_z)
        {
            x = n_x;
            y = n_y;
            z = n_z;
        }

        /*Getter and Setter*/
        float getX()
        {
            return x;
        }
        void setX(float n_x)
        {
            x = n_x;
        }
        float getY()
        {
            return y;
        }
        void setY(float n_y)
        {
            y = n_y;
        }
        float getZ()
        {
            return z;
        }
        void setZ(float n_z)
        {
            z = n_z;
        }

        /*Operator Overloads*/

        /*Unary Operator -*/
        public static Vector operator -(Vector v1)
        {
            Vector tmp = new Vector();
            tmp.setX(v1.x - 1);
            tmp.setY(v1.y - 1);
            tmp.setZ(v1.z - 1);

            return tmp;
        }
        /*Unary Operator +*/
        public static Vector operator +(Vector v1)
        {
            Vector tmp = new Vector();
            tmp.setX(v1.x + 1);
            tmp.setY(v1.y + 1);
            tmp.setZ(v1.z + 1);

            return tmp;
        }

        /*Binary Operator +, two vectors*/
        public static Vector operator +(Vector v1, Vector v2)
        {
            Vector tmp = new Vector();
            tmp.setX(v1.getX() + v2.getX());
            tmp.setY(v1.getY() + v2.getY());
            tmp.setZ(v1.getZ() + v2.getZ());

            return tmp;
        }
        /*Binary Operator -, two vectors*/
        public static Vector operator -(Vector v1, Vector v2)
        {
            Vector tmp = new Vector();
            tmp.setX(v1.getX() - v2.getX());
            tmp.setY(v1.getY() - v2.getY());
            tmp.setZ(v1.getZ() - v2.getZ());

            return tmp;
        }

        /*Binary Operator +, vector + konstant*/
        public static Vector operator +(Vector v1, int k)
        {
            Vector tmp = new Vector();
            tmp.setX(v1.getX() + k);
            tmp.setY(v1.getY() + k);
            tmp.setZ(v1.getZ() + k);

            return tmp;
        }
        /*Binary Operator -, vector - konstant*/
        public static Vector operator -(Vector v1, int k)
        {
            Vector tmp = new Vector();
            tmp.setX(v1.getX() - k);
            tmp.setY(v1.getY() - k);
            tmp.setZ(v1.getZ() - k);

            return tmp;
        }

        /*Override toString for output*/
        public override string ToString()
        {
            return "(" + x + ", " + y + ", " + z + ")";
        }
    }
}
