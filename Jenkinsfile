pipeline {
    agent any

    tools {
        // Define Maven tool named 'Maven 3.9.6'
        maven 'Maven 3.9.6'
    }

    stages {
        stage('Checkout SCM') {
            steps {
                echo 'Checking out source code from SCM...'
                checkout scm
            }
        }
        
        stage('Build') {
            steps {
                echo 'Building the project...'
                // Run Maven clean install
                bat '"E:\\software\\apache-maven-3.9.6\\bin\\mvn" clean install'
            }
        }
    }

    post {
        always {
            echo 'Pipeline execution completed'
        }
        
        success {
            echo 'Build succeeded! Running FindBugs and PMD...'
            // FindBugs plugin
            step([$class: 'FindBugsPublisher', canComputeNew: false, defaultEncoding: '', excludePattern: '', healthy: '', unHealthy: ''])
            // PMD plugin
            step([$class: 'PmdPublisher', canComputeNew: false, defaultEncoding: '', excludePattern: '', healthy: '', unHealthy: '', useStableBuildAsReference: true])
        }
    
        failure {
            echo 'Build failed!'
            // You can add more actions here for failure scenarios
        }
    }
}

