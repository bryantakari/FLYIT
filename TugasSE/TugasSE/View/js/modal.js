<script type="text/javascript">
    $(document).ready(function () {
        $('.delete-button').onclick = (function () {
            document.getElementById('delete-modal').style.display = 'block';
            document.getElementById('fade').style.display = 'block';
        });

        $('.update-modal').click(function () {
            $('.update-modal').slideUp();
        });

        $('.delete-modal').click(function () {
            $('.delete-modal').slideUp();
        });

        function closeDeleteModal() {
            document.getElementById('delete').style.display = 'none';
            document.getElementById('fade').style.display = 'none';
        }

        function openDeleteModal() {
            document.getElementById('myModal1').style.display = 'none';
            document.getElementById('fade').style.display = 'none';
        }
    }
</script>