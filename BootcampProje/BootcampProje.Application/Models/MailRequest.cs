using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampProje.Application.Models
{
    //verileri service layer a iletmek için oluşturulan parametreler.
    public class MailRequest
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        
    }
}
