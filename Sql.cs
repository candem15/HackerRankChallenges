using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class Sql
    {
        /* Product Sales per City

        select c.city_name,p.product_name,ii.line_total_price from city c
        inner join customer cu on cu.city_id=c.id
        inner join invoice i on cu.id=i.customer_id
        inner join invoice_item ii on i.id=ii.invoice_id
        inner join product p on p.id=ii.product_id
        group by p.product_name,c.city_name,ii.line_total_price
        order by ii.line_total_price desc, c.city_name,p.product_name asc
        */

        /* Business Expansion

        WITH pair AS
        (
            SELECT
                ct.user_account_id,
                u.first_name,
                u.last_name,
                c.customer_id,
                ROW NUMBER() OVER(PARTITION BY ct.customer_id,ct.user_account_id ORDER BY ct.user_account_id) as num
            FROM customers c
            INNER JOIN contact ct ON c.id=ct.customer_id
            INNER JOIN user_account u ON u.id=ct.user_account_id
        )
        SELECT * FROM pair WHERE num>1
        */

        /* New Companies

        select
            c.company_code,
            c.founder,
            COUNT(distinct l.lead_manager_code),
            COUNT(distinct s.senior_manager_code),
            COUNT(distinct m.manager_code),
            COUNT(distinct e.employee_code)
        from company c
        inner join lead_manager l on l.company_code=c.company_code
        inner join senior_manager s on s.company_code=l.company_code
        inner join manager m on m.company_code=s.company_code
        inner join employee e on e.company_code=s.company_code
        group by c.company_code,c.founder
        order by c.company_code
        */

        /* active backlogs

        with abc as(
        SELECT DISTINCT student.ID, student.NAME
        FROM backlog
        INNER JOIN student ON student.ID = backlog.STUDENT_ID
        )
        select name from abc order by name asc

        */
    }
}