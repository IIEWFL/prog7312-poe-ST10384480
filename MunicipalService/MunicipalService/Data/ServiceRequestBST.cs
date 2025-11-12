using MunicipalServiceApplication.Models;

namespace MunicipalServiceApplication.Data
{
    public class ServiceRequestBST
    {
        public class Node
        {
            public ServiceRequest Request;
            public Node Left;
            public Node Right;

            public Node(ServiceRequest request)
            {
                Request = request;
            }
        }

        public Node Root;

        public void Insert(ServiceRequest request)
        {
            Root = InsertRec(Root, request);
        }

        private Node InsertRec(Node root, ServiceRequest request)
        {
            if (root == null)
                return new Node(request);

            if (request.RequestID < root.Request.RequestID)
                root.Left = InsertRec(root.Left, request);
            else
                root.Right = InsertRec(root.Right, request);

            return root;
        }

        public ServiceRequest Search(int requestID)
        {
            return SearchRec(Root, requestID);
        }

        private ServiceRequest SearchRec(Node root, int requestID)
        {
            if (root == null)
                return null;

            if (requestID == root.Request.RequestID)
                return root.Request;

            if (requestID < root.Request.RequestID)
                return SearchRec(root.Left, requestID);

            return SearchRec(root.Right, requestID);
        }
    }
}
